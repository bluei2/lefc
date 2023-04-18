using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace LleytonExcellentForwarders.Core
{
    public static class Token {
        public static string GenerateJsonWebToken(){
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("3BC5878B04AD4856933C45A55A578D4B1B9C539A3C1E4E3E9C95EC4118A7A400"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer              : "Excellent",
                audience            : "Forwarders",
                expires             : DateTime.Now.AddHours(3),
                signingCredentials  : credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}