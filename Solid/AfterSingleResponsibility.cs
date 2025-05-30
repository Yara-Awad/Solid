﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class UserService2
    {
        EmailService _emailService;
        DbContext _dbContext;
        public UserService(EmailService aEmailService, DbContext aDbContext)
        {
            _emailService = aEmailService;
            _dbContext = aDbContext;
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            var user = new User(email, password);
            _dbContext.Save(user);
            emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

        }
    }
    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public bool virtual ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public bool SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }

        internal bool ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
