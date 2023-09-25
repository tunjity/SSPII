using Microsoft.IdentityModel.Tokens;
using SSP.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SSP.API
{
    public class TokenManager
    {
        public TokenManager()
        {

        }
        public string GetToken(string username, int rin, IConfiguration config)
        {
            var issuer = config["Jwt:Issuer"];
            var audience = config["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes
            (config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, rin.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, username),
                new Claim(JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString())
             }),
                Expires = DateTime.UtcNow.AddDays(1),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            var stringToken = tokenHandler.WriteToken(token);

            return stringToken;
        }


        public TokenDecryt ValidateToken(string token)
        {
            TokenDecryt tokenDecryt = new();
            var tokenHandler = new JwtSecurityTokenHandler();
            if (token != null)
            {
                token = token.Replace("Bearer ", "").Trim();
                var jsonPayload = tokenHandler.ReadJwtToken(token);
                tokenDecryt = new() { CompanyId = jsonPayload.Subject, ExpiryIn = jsonPayload.ValidFrom.ToString() };

            }
            return tokenDecryt;
        }
    }
}
