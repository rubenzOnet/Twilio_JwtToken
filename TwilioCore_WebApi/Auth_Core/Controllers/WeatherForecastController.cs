using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Get()
        {

            // user.claims

            var idClaim =  User.Claims.FirstOrDefault(w => w.Type.ToString().Equals("Onet.Claim", StringComparison.InvariantCultureIgnoreCase ));

            if(idClaim == null)
            {
                return BadRequest("No Claim");
            }

            return Ok($"This is yout id {idClaim.Value}");
        }
    }
}