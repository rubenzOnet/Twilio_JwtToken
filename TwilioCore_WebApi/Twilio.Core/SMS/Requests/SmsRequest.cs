using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twilio.Core.SMS.Requests
{
    public class SmsRequest
    {
        public string AccountSid { get; set; }
        public string AuthToken { get; set; }
        public string Body { get; set; }
        public string PhoneNumberFrom { get; set; }
        public string PhoneNumberTo { get; set; }

    }
}
