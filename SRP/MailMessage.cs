namespace SRP
{
    public class MailMessage
    {
        public string From { get; }
        public string To { get; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public MailMessage(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}