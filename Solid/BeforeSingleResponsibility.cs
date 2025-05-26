using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
   
        public class UserService
        {
            public void Register(string email, string password)
            {
                if (!ValidateEmail(email))
                    throw new ValidationException("Email is not an email");
                var user = new User(email, password);

                SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
            }
            public virtual bool ValidateEmail(string email)
            {
                return email.Contains("@");
            }
            public bool SendEmail(MailMessage message)
            {
                _smtpClient.Send(message);
            return true;
            }
        }
    
}
