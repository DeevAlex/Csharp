using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace APICatalogo.Services;

public class TokenService : ITokenService
{
    // Codigo responsavel por gerar um token de acesso JWT com base nas reivindicações(claims) fornecidas e utilizamos a 'IConfiguration' para obter essas informações
    public JwtSecurityToken GenerateAccessToken(IEnumerable<Claim> claims, IConfiguration _config)
    {

        var key = _config.GetSection("JWT").GetValue<string>("SecretKey") ?? throw new InvalidOperationException(); // obtendo a chave secreta do 'appsettings.json'

        var privateKey = Encoding.UTF8.GetBytes(key); // convertendo a chave para um array de bytes (porque ela está em formato de string) 

        var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(privateKey), SecurityAlgorithms.HmacSha256Signature); // criando as credenciais para assinar o token (A classe SymmetricSecurityKey é usada emconjunto com a classe SigningCredentials para configurar a chave de assinatura necessária para verificar a autenticidade de tokens JWT.)

        // construção do descritor do token, onde descrevemos as informações que usaremos para gerar o token 
        var tokenDescriptor = new SecurityTokenDescriptor()
        {

            Subject = new ClaimsIdentity(claims), // obtendo as informações sobre o usuario
            Expires = DateTime.UtcNow.AddMinutes(_config.GetSection("JWT").GetValue<double>("TokenValidityInMinutes")), // definindo a data de expiração e obtendo do 'appsettings.json'
            Audience = _config.GetSection("JWT").GetValue<string>("ValidAudience"), // obtendo a audiencia
            Issuer = _config.GetSection("JWT").GetValue<string>("ValidIssuer"), // obtendo o emissor
            SigningCredentials = signingCredentials // definindo as credenciais de assinatura que geramos 'signingCredentials'

        };

        var tokenHandler = new JwtSecurityTokenHandler(); // criando um manipulador do Token JWT instanciando um objeto 'JwtSecurityTokenHandler', que é responsavel por criar e validar os Tokens

        var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor); // Gerando o Token

        return token;


    }

    // RefreshToken - Token de Atualização, que é usado para obter um novo token de acesso, utilizado para facilitar a experiencia do usuario
    public string GenerateRefreshToken()
    {

        var secureRandomBytes = new byte[128]; // vai ser usado para armazenar bytes aleatorios que serão gerados de forma segura

        using var randomNumberGenerator = RandomNumberGenerator.Create(); // criando um gerador de numeros aleatorios 

        randomNumberGenerator.GetBytes(secureRandomBytes); // preenchendo a variavel 'secureRandomBytes' com bytes aleatorios gerados utilizando a classe 'RandomNumberGenerator' 

        var refreshToken = Convert.ToBase64String(secureRandomBytes); // fazendo uma representação de string no formato base 64 com os bytes gerados aleatoriamente, fazemos isso para que o token de atualização seja legivel, facil de armazenar ou de trasmitir

        return refreshToken;

    }

    // usado para validar o Token de acesso que foi expirado, e ele retorna as claims do token expirado
    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token, IConfiguration _config)
    {

        var secretKey = _config["JWT:SecretKey"] ?? throw new InvalidOperationException("Invalid SecretKey");

        // parametros de validação para o token JWT expirado
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
            ValidateLifetime = false,
        };

        var tokenHandler = new JwtSecurityTokenHandler(); // para manipular o token JWT

        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken); // utilizamos um metodo da instancia do Handler para validar o Token JWT com base nos parametros de validação, e ele tem um parametro de saida 'securityToken' ao final da execução do metodo vai ser preenchida essa variavel de saida 

        if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase)) // verificando se 'securityToken' não for uma instancia de 'JwtSecurityToken' e se o algoritmo utilizado é o HmacSha256 vai ser lançada uma exceção
        {
            throw new SecurityTokenException("Invalid Token");
        }

        return principal;

    }
}
