using Microsoft.AspNetCore.Mvc;
using Twilio.Core.WhatsApp.Requests;
using Twilio.Core.WhatsApp.Services;

namespace TwilioCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendTwilioWhatsAppController : ControllerBase
    {

        private readonly ITwilioWhatsApp _twilioWhatsApp;

        public SendTwilioWhatsAppController(ITwilioWhatsApp twilioWhatsApp)
        {
            _twilioWhatsApp = twilioWhatsApp;
        }

        // POST api/<SendTwilioWhatsAppController>
        [HttpPost]
        public ActionResult Post([FromBody] WhatsAppRequest whatsAppRequest)
        {
            string result = _twilioWhatsApp.TwilioSendWhatsApp(whatsAppRequest);

            if (result == "Not Send")
                return BadRequest();


            return Ok("The Whats App has been send successfully");
        }

    
    }
}
