using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Utility.Lib.Domains.Notification
{
    public sealed class EmailMessage
    {
        [Required]
        [EmailAddress]
        public string To { get; }
        [Required]
        [EmailAddress]
        public string From { get; }
        public string FromDisplayName { get; }
        [Required]
        [StringLength(200, ErrorMessage = "Subject should not be more than 200 characters", MinimumLength = 1)]
        public string Subject { get; }
        [Required]
        public string Body { get; }
        public string? Cc { get; }
        public string? Bcc { get; }
        public List<Attachment>? Attachments { get; }

        public EmailMessage(string to,
                            string from,
                            string subject,
                            string body,
                            List<Attachment>? attachments = null,
                            string? cc = null,
                            string? bcc = null,
                            string? fromDisplayName = null)
        {
            this.To = to;
            this.From = from;
            this.Subject = subject;
            this.Body = body;
            this.Attachments = attachments;
            this.Cc = cc;
            this.Bcc = bcc;
            this.FromDisplayName = fromDisplayName?? from;
        }
    }
}
