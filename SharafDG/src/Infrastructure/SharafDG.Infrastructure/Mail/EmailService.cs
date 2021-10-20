using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;
using SharafDG.Application.Contracts.Infrastructure;
using SharafDG.Application.Models.Mail;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SharafDG.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        public MailSettings _mailSettings { get; }
        public ILogger<EmailService> _logger { get; }

        public EmailService(IOptions<MailSettings> mailSettings, ILogger<EmailService> logger)
        {
            _mailSettings = mailSettings.Value;
            _logger = logger;
        }

        public async Task<bool> SendEmail(Email email)
        {

            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var emailBody = email.Body;

            //var client = new SendGridClient(_emailSettings.ApiKey);
            var client = new SendGridClient("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");

           /* var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName
            };*/
            var from = new EmailAddress
            {
                Email = "gill@test.com",
                Name = "Sharaf DG",
            };
            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
            var response = await client.SendEmailAsync(sendGridMessage);

            _logger.LogInformation("Email sent");

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;

            _logger.LogError("Email sending failed");

            return false;
        }

       
    }
}
