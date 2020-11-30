using System;

namespace SRP
{
    // Single Responsibility Principle
    public class UserService
    {
        private readonly MailService _mailService;
        public UserService(MailService mailService)
        {
            _mailService = mailService;
        }
        public void Register(string email, string password)
        {
            if (_mailService.ValidateEmail(email))
                throw new Exception("Email geçerli değil.");
            var user = new User(email, password);

            _mailService.SendEmail(new MailMessage("samet.emek@inventiv.com.tr", email) { Subject = "Hello World!" });
            //Save user.
        }

    }
    //KISS -> Keep it simple and stupid. 
    public class MailService
    {
        private SmtpClient _smtpClient;

        public MailService()
        {
            _smtpClient = new SmtpClient();
        }
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }

}
