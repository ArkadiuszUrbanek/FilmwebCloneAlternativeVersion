using FilmwebCloneBackend.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FilmwebCloneBackend.Services
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;

        public JwtService(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<string> CreateTokenAsync(User user)
        {
            return new JwtSecurityTokenHandler()
                .WriteToken(new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: new Claim[]
                        {
                            new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()),
                            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                            new Claim(ClaimTypes.GivenName, user.FirstName),
                            new Claim(ClaimTypes.Surname, user.LastName),
                            new Claim(ClaimTypes.Email, user.Email!),
                            new Claim(ClaimTypes.Gender, user.Gender.ToString()),
                            new Claim(ClaimTypes.Role, (await _userManager.GetRolesAsync(user)).Single())
                        },
                    expires: DateTime.UtcNow.AddMinutes(double.Parse(_configuration["Jwt:ExpirationTimeInMinutes"]!)),
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecurityKey"]!)), SecurityAlgorithms.HmacSha256)
                )
            );
        }
    }
}
