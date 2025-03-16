using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace E_Commerce.Business.Service;

public class JwtGeneratorService:IJwtGenerator
{
    private readonly string _key;
    private readonly string _issuer;
    private readonly string _audience;
    private readonly int _expireMinutes;
    
    

    public JwtGeneratorService(IConfiguration configuration)
    {
        _key = configuration["JWT:Key"];
        _issuer = configuration["JWT:Issuer"];
        _audience = configuration["JWT:Audience"];
        _expireMinutes = int.Parse(configuration["JWT:ExpireMinutes"]);
    }
    
    
    
    public string GenerateToken(UserDto userDto)
    {
         //Claims
         var claims = new List<Claim>
         {
             new Claim(JwtRegisteredClaimNames.Sub, userDto.userName),
             new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             new Claim(JwtRegisteredClaimNames.Email, userDto.email),
             new Claim(JwtRegisteredClaimNames.UniqueName, userDto.userName),
           
             //new Claim(JwtRegisteredClaimNames.Exp,_expireMinutes.ToString())
         };

         
         foreach (var role in userDto.kullaniciRolu)
         {
             claims.Add(new Claim(ClaimTypes.Role, role.roleName));
         }
        
         var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
         var credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

         var token = new JwtSecurityToken(
             _issuer,
             _audience,
             claims,
             expires: DateTime.UtcNow.AddMinutes(_expireMinutes),
             signingCredentials: credentials
         );
         
         return new JwtSecurityTokenHandler().WriteToken(token);
         
    }
}