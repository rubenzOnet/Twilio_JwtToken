using Twilio.Core.WhatsApp.Requests;

namespace Twilio.Core.WhatsApp.Services
{
    public interface ITwilioWhatsApp
    {
        string TwilioSendWhatsApp(WhatsAppRequest whatsAppRequest);
    }
}
