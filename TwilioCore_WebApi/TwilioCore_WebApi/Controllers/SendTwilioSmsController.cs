using Microsoft.AspNetCore.Mvc;
using Twilio.Core.SMS.Requests;
using Twilio.Core.SMS.Services;


namespace TwilioCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendTwilioSmsController : ControllerBase
    {

        private readonly ITwilioSMS _twilioSMS;

        public SendTwilioSmsController(ITwilioSMS twilioSMS)
        {
            _twilioSMS = twilioSMS;
        }


        [HttpPost]
        public ActionResult Post([FromBody] SmsRequest smsRequest)
        {

            string result = _twilioSMS.TwilioSendSms(smsRequest);

            if (result == "Not Send")
                return BadRequest();


            return Ok(result);
        }

       
    }
}
