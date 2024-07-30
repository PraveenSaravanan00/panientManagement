using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using practice1.Model;
using System.Security.Claims;
using System.Text;

namespace practice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private IConfiguration _configuration;
        public loginController(IConfiguration configuration) { 
            _configuration = configuration;
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult login([FromBody] ModelInfo modellogin) {
        //    var user = Authenticate(modellogin);
        //    if (user!=null) {
        //        var token = Generate(user);
        //        return Ok(token);
        //    }
        //    return NotFound("User not Found");
        //}

        //private string Generate(userinformation user)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        //    var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
        //    var claims = new[] { 
        //    new Claim(ClaimTypes.NameIdentifier, Users.patientName),

        //    };
        //    throw new NotImplementedException();
        //}

        //private userinformation Authenticate(ModelInfo modellogin)
        //{
        //    var CurrentUser = userinformation.Users.FirstOrDefault(o => o.patientName.ToLower() == modellogin.ModelName && o.patientId== modellogin.ModelId);
        //    if (CurrentUser!=null) {
        //        return CurrentUser;
        //    }
        //    return null;
        
        //}
    }
}
