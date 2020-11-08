using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace DIP.Sample2.Final
{
    public abstract class NotificationSender
    {
        public abstract void SendNotification();
    }

    public class PushSender : NotificationSender
    {
        public override void SendNotification()
        {
            //Send push to all users
        }
    }

    public class EmailSender : NotificationSender
    {
        public override void SendNotification()
        {
            //Send email
        }
    }

    public class SmsSender : NotificationSender
    {
        public override void SendNotification()
        {
            //Send sms
        }
    }

    public class UserManager
    {
        private readonly NotificationManager _notificationManager;
        public UserManager()
        {
            _notificationManager = new NotificationManager(new List<NotificationSender>() { new EmailSender(), new SmsSender(), new PushSender() });
        }

        public void HebeleHubele()
        {
            _notificationManager.Sender();
        }
    }


    public class NotificationManager
    {
        private readonly List<NotificationSender> _notificationSenders;

        public NotificationManager(List<NotificationSender> notificationSenders)
        {
            this._notificationSenders = notificationSenders;
        }

        public void Sender()
        {
            foreach (var notificationSender in _notificationSenders)
            {
                notificationSender.SendNotification();
            }
        }
    }
}
