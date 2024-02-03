using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ECommerceWeb.Shared.Request;
using ECommerceWeb.Shared.Response;
using Microsoft.IdentityModel.Tokens;

namespace ECommerceWeb.Server.Services;

public class UserService : IUserService
{
    private readonly IConfiguration _configuration;

    public UserService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<LoginDtoResponse> LoginAsync(LoginDtoRequest request)
    {
        // Validamos el usuario y clave.

        if (request.Usuario == "admin" && request.Password == "admin")
        {

            // Vamos a devolver los Claims
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Administrador del sistema"),
            };

            // Creamos el JWT
            var llaveSimetrica = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]!));
            var credenciales = new SigningCredentials(llaveSimetrica, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(credenciales);

            var payload  = new JwtPayload(
                               _configuration["Jwt:Issuer"],
                               _configuration["Jwt:Audience"],
                               claims,
                               DateTime.Now,
                               DateTime.Now.AddHours(1)
                               );

            var jwtToken = new JwtSecurityToken(header, payload);
            
            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return new LoginDtoResponse(token, "Administrador del sistema");
        }
        else
        {
            return new LoginDtoResponse(string.Empty, string.Empty);
        }
    }
}