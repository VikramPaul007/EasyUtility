using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Utility.Lib.Domains.Notification;
public sealed class EmailMessage
{
    [Required]
    [EmailAddress]
    public string To { get; init; }
    [Required]
    [EmailAddress]
    public string From { get; init; }
    public string FromDisplayName { get; init; }
    [Required]
    [StringLength(999, ErrorMessage = "Subject should be less than 1000 characters", MinimumLength = 1)]
    public string Subject { get; init; }
    [Required]
    public string Body { get; init; }
    public string Cc { get; init; }
    public string Bcc { get; init; }
    public List<Attachment> Attachments { get; init; }

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
        this.FromDisplayName = fromDisplayName;
    }
}
