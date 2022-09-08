

using Twilio;
using Twilio.Rest.Api.V2010.Account;

// Find your Account SID and Auth Token at twilio.com/console
// and set the environment variables. See http://twil.io/secure
string accountSid = "AC261c27c34a7beaeb9534958ee529a612";
string authToken = "4d2b710b6eeefc2d6237f0c2e8586ed3";

TwilioClient.Init(accountSid, authToken);

var message = MessageResource.Create(
    body: "Este es un texto desde C# a mi telefono",
    from: new Twilio.Types.PhoneNumber("+18149148429"),
    to: new Twilio.Types.PhoneNumber("+525518749680")
);

Console.WriteLine(message.Sid);