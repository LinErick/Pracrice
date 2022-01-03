using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SqlConnect;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiExample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class JwtController : ControllerBase
    {
        readonly string Secret;
        readonly AppSettings settings;
        public JwtController(IConfiguration configuration, IOptions<AppSettings> appSettings)
        {
            Secret = configuration.GetValue<string>("AppSettings:Secret");
            settings = appSettings.Value;
        }
        [HttpGet]
        public ActionResult GetToken()
        {
            var symmetricKey = Encoding.UTF8.GetBytes(settings.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "TestJwt"),
                    new Claim(ClaimTypes.GivenName,"GivenNameTest")
                }),

                Expires = DateTime.UtcNow.AddDays(7),

                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(symmetricKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);


            return Ok(token);
        }
        [HttpGet]
        public ActionResult DecodeToken(string token)
        {
            var stream = token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = jsonToken as JwtSecurityToken;

            return Ok(new { tokenS });
        }
        [HttpGet]
        [Authorize]
        public ActionResult TokenIsSuccess()
        {
            return Ok();
        }
    }
}
