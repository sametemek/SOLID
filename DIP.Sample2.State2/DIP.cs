using System;

namespace DIP.Sample2.State1
{
    // YENİ GELDİ.
    public class PushSender
    {
        public void SendPush()
        {
            //Send push to all users
        }
    }

    public class EmailSender
    {
        public void SendEmail()
        {
            //Send email to all users
        }
    }
    public class SmsSender
    {
        public void SendSms()
        {
            //Send sms to all users.
        }
    }

    public class UserManager
    {
        private readonly NotificationManager _notificationManager;
        public UserManager()
        {
            _notificationManager = new NotificationManager();
        }

        public void HebeleHubele()
        {
            _notificationManager.Sender();
        }
    }


    public class NotificationManager
    {
        private readonly EmailSender _emailSender = new EmailSender();
        private readonly SmsSender _smsSender = new SmsSender();
        private readonly PushSender _pushSender = new PushSender();

        public void Sender()
        {
            _emailSender.SendEmail();
            _smsSender.SendSms();
            _pushSender.SendPush();

        }
    }
}