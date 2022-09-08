using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twilio.Core.WhatsApp.Requests
{
    public class WhatsAppRequest
    {
        public string AccountSid { get; set; }
        public string AuthToken { get; set; }
        public string Body { get; set; }
        public string PhoneNumberFrom { get; set; }
        public string PhoneNumberTo { get; set; }
    }
}
