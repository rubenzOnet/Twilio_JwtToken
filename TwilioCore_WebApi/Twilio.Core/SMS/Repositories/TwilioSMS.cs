using Twilio.Core.SMS.Requests;
using Twilio.Core.SMS.Services;
using Twilio.Rest.Api.V2010.Account;


namespace Twilio.Core.SMS.Repositories
{
    public class TwilioSMS : ITwilioSMS
    {
        public string TwilioSendSms(SmsRequest Message)
        {
            try
            {
                TwilioClient.Init(Message.AccountSid, Message.AuthToken);

                var message = MessageResource.Create(
                    body: Message.Body,
                    from: new Types.PhoneNumber(Message.PhoneNumberFrom),
                    to: new Types.PhoneNumber(Message.PhoneNumberTo)
                );

                return message.Sid;
            }
            catch (Exception ex)
            {
                return "Not Send";
            }

        }
    }
}
