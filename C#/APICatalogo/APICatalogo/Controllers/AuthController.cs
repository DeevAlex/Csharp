using APICatalogo.DTOs;
using APICatalogo.Models;
using APICatalogo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace APICatalogo.Controllers;

// Para utilizar o serviço TokenService devemos registrar o mesmo no Container DI na classe Program.cs
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{

    private readonly ITokenService? _tokenService; // injetando o serviço do token
    private readonly UserManager<ApplicationUser>? _userManager; // injetando o userManager com o 'ApplicationUser', ele vai tratar com os usuarios 
    private readonly RoleManager<IdentityRole>? _roleManager; // vai tratar com os perfis, as permissões do usuario
    private readonly IConfiguration? _config; // vai ser usado para acessarmos as informações que foram definidas no 'appsettings.json'

    public AuthController(ITokenService? tokenService, UserManager<ApplicationUser>? userManager, RoleManager<IdentityRole>? roleManager, IConfiguration? config)
    {
        _tokenService = tokenService;
        _userManager = userManager;
        _roleManager = roleManager;
        _config = config;
    }

    [HttpPost]
    [Route("login")]
    public async Task<ActionResult> Login([FromBody] LoginModel model)
    {

        var user = await _userManager.FindByNameAsync(model.Username!); // verificando se o usuario existe, o ! é o operador de supressão de verificação de nulo no C#, ele indica para o compilador que tem certeza que 'Username' não é nulo, assim ele inibe o alerta do compilador

        if (user is not null && await _userManager.CheckPasswordAsync(user, model.Password!)) // verificando se ele não é nulo e verificando se a senha fornecida é valida
        {

            var userRoles = await _userManager.GetRolesAsync(user); // obtendo os perfis desse usuario

            var authClaims = new List<Claim> // criando uma lista de Claims que são usadas para construir o token de acesso durante o processo de autenticação 
            {
                new Claim(ClaimTypes.Name, user.UserName!),
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // essa claim é usada para fornecer um identificador exclusivo para o token (Um GUID é uma sequência de caracteres hexadecimal de 32 digitos, geralmente exibida em grupos separados por hifens, como "6F9619FF-8B86-D011-B42D-00C04FC964FF".)
            };

            foreach(var userRole in userRoles) // iterando sobre os perfis que obtivemos do usuario
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole)); // adicionando as claims correspondentes ao token de autenticação, isso é util para incluir os perfis do usuario no token de autenticação então esses perfis pode posteriormente usados para autorizar o acesso a recursos com base nas permissões associadas a cada perfil, por exemplo se eu tiver um perfil admin ou user essas informações serão incluidas no token como claims dos perfis, permitindo que o sistema tome decisões com base nessas permissões associadas a esses perfis durante os requests
            }

            var token = _tokenService!.GenerateAccessToken(authClaims, _config!); // aqui ele vai gerar o token 

            var refreshToken = _tokenService.GenerateRefreshToken(); // gerando o token de atualização

            _ = int.TryParse(_config["JWT:RefreshTokenValidityInMinutes"], out int refreshTokenValidityInMinutes); // obtendo a data de validação la do 'appsettings.json', dai convertemos vao valor de lá para int e armazenamos ele na variavel de saida 'refreshTokenValidityInMinutes', o _ é o operador discard, é geralmente utilizado quando não estamos interessados no retorno da operação _config[] porque já estamos armazenando o resultado na variavel de saida, com isso não é alocado memoria

            user.RefreshToken = refreshToken;

            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(refreshTokenValidityInMinutes); // convertendo para 'DateTime' e armazena na propriedade 'RefreshTokenExpiryTime' do usuario

            await _userManager.UpdateAsync(user); // atualizando as informações lá na tabela ASPNETUSERS, persistindo as alterações feitas no objeto user de volta no banco de dados

            // retornando um objeto JSON contendo o token de acesso, o refreshToken e a data de expiração
            return Ok(new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                RefreshToken = refreshToken,
                Expiration = token.ValidTo,
            });

        }

        // caso a verificação anterior não seja verdadeira irá retornar o codigo 401 - Unauthorized
        return Unauthorized();

    }

    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
    {

        var userExists = await _userManager!.FindByNameAsync(registerModel.Username!); // procurando se o nome de usuario existe

        if (userExists != null) // se existir manda um statuscode 500
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Erro", Message = "User already exists" });
        }

        ApplicationUser user = new() // caso não exista cria uma instancia de 'ApplicationUser' com os dados informados no 'registerModel'
        {
            Email = registerModel.Email,
            SecurityStamp = Guid.NewGuid().ToString(), // isso vai ser transformado em string que será armazenado nas tabelas do Identity
            UserName = registerModel.Username,
        };

        var result = await _userManager.CreateAsync(user, registerModel.Password!); // cria o usuario

        if (!result.Succeeded) // se não for criado com sucesso vai retornar um erro 500
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Erro", Message = "User Creation Faild" });
        }

        return Ok(new Response { Status = "Success", Message = "User Create Successfully" }); // mostra que o usuario foi criado

    }

    [HttpPost]
    [Route("refresh-token")]
    public async Task<IActionResult> RefreshToken(TokenModel tokenModel) // o tokenModel terá o refresh-token e token JWT Expirado
    {

        if (tokenModel == null)
        {
            return BadRequest("Invalid client request");
        }

        string? accessToken = tokenModel.AccessToken ?? throw new ArgumentNullException(nameof(tokenModel)); // obtendo o AccessToken 

        string? refreshToken = tokenModel.RefreshToken ?? throw new ArgumentException(nameof(tokenModel));

        var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken, _config); // obtendo as claims a partir do token jwt expirado

        if (principal == null)
        {
            return BadRequest("Invalid access token/refresh-token");
        }

        string username = principal.Identity.Name; // a partir das claims obtemos o nome de usuario

        var user = await _userManager.FindByNameAsync(username!); // localizando esse usuario na BD

        if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now) // se o usuario existe, dai comparamos o 'refreshToken' que foi informado com o 'RefreshToken' que está armazenado na tabela para este usuario também iremos verificar se a data de expiração do 'RefreshToken' que está armazenada é menor ou igual a data atual
        {
            return BadRequest("Invalid access token/refresh token");
        }

        var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims.ToList(), _config); // gerando um novo Token de acesso passando as claims que obtivemos e a instancia de 'IConfiguration'

        var newRefreshToken = _tokenService.GenerateRefreshToken(); // gerando um novo RefreshToken

        user.RefreshToken = newRefreshToken; // atualizamos o 'RefreshToken' do usuario que vamos armazenar na tabela 
        await _userManager.UpdateAsync(user); // e peristimos as informações

        return new ObjectResult(new
        {
            accessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
            refreshToken = newRefreshToken,
        });

    }

    [Authorize]
    [HttpPost]
    [Route("revoke/{username}")]
    public async Task<IActionResult> Revoke(string username)
    {

        var user = await _userManager.FindByNameAsync(username); // localizando o usuario pelo nome passado na url

        if (user == null) return BadRequest("Invalid UserName"); // caso não exista manda BadRequest

        user.RefreshToken = null; // definimos null para o RefreshToken do usuario

        await _userManager.UpdateAsync(user); // atualizamos as informações no BD

        return NoContent(); // 204

    }

}
