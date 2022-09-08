using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        var accountSid = "AC261c27c34a7beaeb9534958ee529a612";
        var authToken = "4d2b710b6eeefc2d6237f0c2e8586ed3";
        TwilioClient.Init(accountSid, authToken);

        var messageOptions = new CreateMessageOptions(new PhoneNumber("whatsapp:+5215518749680"));
        messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
        messageOptions.Body = "Hola, este mensage se envió desde Twilio hacia Whatsapp";

        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }
}