using System;

namespace SRP
{
    // Single Responsibility Principle
    public class UserService
    {
        private SmtpClient _smtpClient;

        public UserService()
        {
            _smtpClient = new SmtpClient();
        }
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email geçerli değil.");
            var user = new User(email, password);

            SendEmail(new MailMessage("samet.emek@inventiv.com.tr", email) { Subject = "Hello World!" });
            //Save user.
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
