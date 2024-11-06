using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System;
using System.Collections.Generic;

namespace dharmendraPradhan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioController : ControllerBase
    {
        private const string AccountSid = "your_account_sid";
        private const string AuthToken = "your_auth_token";

        public TwilioController()
        {
            TwilioClient.Init(AccountSid, AuthToken);
        }

        [HttpPost("send")]
        public IActionResult SendMessage(string to, string body)
        {
            var fromWhatsAppNumber = new PhoneNumber("whatsapp:+14155238886"); // Twilio sandbox number
            var toWhatsAppNumber = new PhoneNumber($"whatsapp:{to}");

            var message = MessageResource.Create(
                body: body,
                from: fromWhatsAppNumber,
                to: toWhatsAppNumber
            );

            return Ok(new { message.Sid, body });
        }

        [HttpPost("receive")]
        public IActionResult ReceiveMessage([FromForm] string Body, [FromForm] string From)
        {
            // Process incoming message here, store it in database, etc.
            Console.WriteLine($"Message from {From}: {Body}");

            return Ok(); // Twilio expects a 200 OK response
        }
    }
}
