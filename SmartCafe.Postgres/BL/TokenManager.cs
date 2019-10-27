using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.BL
{
    public static class TokenManager
    {
        public static string GenerateToken(object payload)
        {
            string signingKey = Startup.StaticConfig["Token:SigningKey"];

            var claims = new Dictionary<string, object>() {
                { "Payload", payload }
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Claims = claims,

                Expires = DateTime.UtcNow.AddDays(1),

                SigningCredentials =
                    new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey)),
                        SecurityAlgorithms.HmacSha256Signature)                
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}
