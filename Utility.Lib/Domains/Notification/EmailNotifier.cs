using System.Net.Mail;

namespace Utility.Lib.Domains.Notification
{
    internal sealed class EmailNotifier : INotifier
    {
        private readonly SmtpClient smtpClient;
        private readonly EmailMessage emailMessage;

        public EmailNotifier(SmtpClient smtpClient,
            EmailMessage emailMessage)
        {
            this.smtpClient = smtpClient;
            this.emailMessage = emailMessage;
        }
        public bool Notify()
        {
            using (MailMessage mailMessage = new MailMessage()
            {
                Subject = emailMessage.Subject,
                Body = emailMessage.Body
            })
            {

                mailMessage.From =
                    new MailAddress(emailMessage.From, emailMessage.FromDisplayName ?? emailMessage.From);

                smtpClient.Send(mailMessage);
            }

            return true;
        }
    }
}
