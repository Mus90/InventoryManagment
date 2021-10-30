using InventoryManagement.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public class EmailSender : IEmailSender
    {
        private SmtpOptions _smtpOptions { get; }

        public EmailSender(IOptions<SmtpOptions> smtpOptions)
        {
            _smtpOptions = smtpOptions.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            SendEmailByGmailAsync(_smtpOptions.fromEmail,
                                            _smtpOptions.fromFullName,
                                            subject,
                                            message,
                                            email,
                                            email,
                                            _smtpOptions.smtpUserName,
                                            _smtpOptions.smtpPassword,
                                            _smtpOptions.smtpHost,
                                            _smtpOptions.smtpPort,
                                            _smtpOptions.smtpSSL)
                                            .Wait();


            return Task.CompletedTask;
        }

        public async Task SendEmailByGmailAsync(string fromEmail,
            string fromFullName,
            string subject,
            string messageBody,
            string toEmail,
            string toFullName,
            string smtpUser,
            string smtpPassword,
            string smtpHost,
            int smtpPort,
            bool smtpSSL)
        {
            var body = messageBody;
            var message = new MailMessage();
            message.To.Add(new MailAddress(toEmail, toFullName));
            message.From = new MailAddress(fromEmail, fromFullName);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = smtpUser,
                    Password = smtpPassword
                };
                smtp.Credentials = credential;
                smtp.Host = smtpHost;
                smtp.Port = smtpPort;
                smtp.EnableSsl = smtpSSL;
                await smtp.SendMailAsync(message);

            }

        }
    }
}
