using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auth_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {

        [HttpPost("token")]
        public ActionResult GetToken()
        {

            // security token
            string SecurityToken = "Lorem_ipsum_dolor_sit_amet_consectetur_adipisicing_elit_sed_do_eiusmod";


            //simmetric security token
            var SimmeticSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityToken));



            //singing credentials
            var singingCredentials = new SigningCredentials(SimmeticSecurityKey, SecurityAlgorithms.HmacSha256Signature);


            // add claims
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            claims.Add(new Claim(ClaimTypes.Role, "Reader"));
            claims.Add(new Claim("Onet.Claim", "OnetClaim"));
            claims.Add(new Claim("id", "45678955"));


            //create token
            var token = new JwtSecurityToken(
                issuer: "onet.in",
                audience: "readers",
                expires: DateTime.Now.AddHours(1),
                signingCredentials: singingCredentials,
                claims: claims
            );


            // return token
            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }

    }
}
