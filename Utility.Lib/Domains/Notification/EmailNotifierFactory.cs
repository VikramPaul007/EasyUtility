using System.Net.Mail;

namespace Utility.Lib.Domains.Notification
{
    public sealed class EmailNotifierFactory : INotifierFactory
    {
        private readonly SmtpClient smtpClient;
        private readonly EmailMessage emailMessage;

        public EmailNotifierFactory(SmtpClient smtpClient,
            EmailMessage emailMessage)
        {
            this.smtpClient = smtpClient;
            this.emailMessage = emailMessage;
        }
        public INotifier CreateNotifier()
        {
            return new EmailNotifier(smtpClient, emailMessage);
        }
    }
}
