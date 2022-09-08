using Twilio.Core.WhatsApp.Requests;
using Twilio.Core.WhatsApp.Services;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Twilio.Core.WhatsApp.Repositories
{
    public class TwilioWhatsApp : ITwilioWhatsApp
    {

        public string TwilioSendWhatsApp(WhatsAppRequest whatsAppRequest)
        {
            try
            {

                TwilioClient.Init(whatsAppRequest.AccountSid, whatsAppRequest.AuthToken);

                var messageOptions = new CreateMessageOptions(new PhoneNumber($"whatsapp:{whatsAppRequest.PhoneNumberTo}"));
                messageOptions.From = new PhoneNumber($"whatsapp:{whatsAppRequest.PhoneNumberFrom}");
                messageOptions.Body = whatsAppRequest.Body;

                MessageResource message = MessageResource.Create(messageOptions);

                return message.Body;

            }
            catch (Exception)
            {
                return "Not Send";
            }

        }

    }
}
