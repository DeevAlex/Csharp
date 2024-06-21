using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace APICatalogo.Services;

public interface ITokenService
{

    // claims é uma lista de informações sobre o usuario e uma instancia de 'IConfiguration'
    JwtSecurityToken GenerateAccessToken(IEnumerable<Claim> claims, IConfiguration _config);

    string GenerateRefreshToken();

    ClaimsPrincipal GetPrincipalFromExpiredToken(string token, IConfiguration _config); // esse metodo vai ser implementado na classe concreta para extrair as informações das claims do token que foi gerado, o Token JWT ele contém as claims do usuario (as info do usuario), como esse metodo vamos extrair isso do token expirado para poder gerar um novo Token de acesso usando o RefreshToken

}
