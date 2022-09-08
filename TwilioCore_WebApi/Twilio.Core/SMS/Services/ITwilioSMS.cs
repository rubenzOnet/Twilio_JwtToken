using Twilio.Core.SMS.Requests;

namespace Twilio.Core.SMS.Services
{
    public interface ITwilioSMS
    {
        string TwilioSendSms(SmsRequest Message);
    }
}
