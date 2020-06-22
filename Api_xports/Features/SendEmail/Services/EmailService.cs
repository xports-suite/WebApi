using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using Remotion.Linq.Parsing.Structure.ExpressionTreeProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Api_xports.Features.SendEmail.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="message"></param>
        /// <param name="subject"></param>
        /// <returns></returns>
        public async Task SendEmail(string email, string message,string subject)
        {
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = _configuration["Email:Email"],
                    Password = _configuration["Email:Password"]
                };

                client.Credentials = credential;
                client.Host = _configuration["Email:Host"];
                client.Port = int.Parse(_configuration["Email:Port"]);
                client.EnableSsl = false;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(email));
                    emailMessage.From = new MailAddress(_configuration["Email:Email"]);
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    client.Send(emailMessage);
                }
            }
            await Task.CompletedTask;
        }
    }
}
