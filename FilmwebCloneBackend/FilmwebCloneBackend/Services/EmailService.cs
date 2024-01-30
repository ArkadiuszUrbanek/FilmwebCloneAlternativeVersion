using System.Net;
using System.Net.Mail;

namespace FilmwebCloneBackend.Services
{
    public class EmailService
    {
        IConfiguration _configuration;
        public EmailService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string recipentEmail, string subject, string body, bool isBodyHtml)
        {
            string address = _configuration["SmtpClient:Address"]!;
            string password = _configuration["SmtpClient:Password"]!;

            var client = new SmtpClient(host: _configuration["SmtpClient:Host"], port: Convert.ToInt32(_configuration["SmtpClient:Port"]))
            {
                EnableSsl = Convert.ToBoolean(_configuration["SmtpClient:EnableSSL"]),
                Credentials = new NetworkCredential(address, password)
            };

            var message = new MailMessage(from: address, to: recipentEmail, subject: subject, body: body);
            message.IsBodyHtml = isBodyHtml;

            await client.SendMailAsync(message);


            //var secureSocketOptions = SecureSocketOptions.None;
            //if (Convert.ToBoolean(_configuration["SmtpClient:EnableTLS"])) secureSocketOptions = SecureSocketOptions.StartTls;

            //using var smtp = new SmtpClient();
            //smtp.Connect(host: _configuration["SmtpClient:Host"], port: Convert.ToInt32(_configuration["SmtpClient:Port"]), secureSocketOptions);
            //if (Convert.ToBoolean(_configuration["SmtpClient:EnableTLS"])) smtp.Authenticate(_configuration["SmtpClient:Address"]!, _configuration["SmtpClient:Password"]!);
            //await smtp.SendAsync(email);
            //smtp.Disconnect(true);
        }
    }
}
