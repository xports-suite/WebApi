using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.SendEmail.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEmailService
    {
        ///
        Task SendEmail(string email, string message, string subject);
    }
}
