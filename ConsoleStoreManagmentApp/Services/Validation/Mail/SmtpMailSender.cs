
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace OnlineStore.Services.Validation.Mail
{
    public class SmtpMailSender : IMailSender
    {
        private SmtpOptions _options;
        public SmtpMailSender(SmtpOptions options)
        {
            _options = options;
        }
        public async Task SendAsyn(string toMail, string subject, string body)
        {
            var fromAddress = new MailAddress(_options.User, _options.FromName);
            var toAddress = new MailAddress(toMail);

            using var smtp = new SmtpClient(_options.Server, _options.Port)
            {
                Credentials = new NetworkCredential(_options.User, _options.Password),
                EnableSsl = true
            };

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            await smtp.SendMailAsync(message);
        }
    }
}