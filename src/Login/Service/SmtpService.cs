using System.Net.Mail;
using System.Net;

namespace Login.Service;

public class SmtpService
{
    static SmtpClient? _client;

    /// <summary>
    /// Initializes a new instance of the <see cref="SmtpService"/> class using default Outlook SMTP settings.
    /// </summary>
    /// <param name="userName">The SMTP username.</param>
    /// <param name="password">The SMTP password.</param>
    public SmtpService(string? userName, string? password)
    {
        _client = this.CreateConnection("smtp-mail.outlook.com", 587, userName, password) ?? throw new ArgumentNullException(nameof(SmtpService));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmtpService"/> class with custom SMTP settings.
    /// </summary>
    /// <param name="host">The SMTP server host.</param>
    /// <param name="port">The SMTP server port.</param>
    /// <param name="userName">The SMTP username.</param>
    /// <param name="password">The SMTP password.</param>
    public SmtpService(string? host, int port, string? userName, string? password)
    {
        _client = this.CreateConnection(host, port, userName, password);
    }

    /// <summary>
    /// Creates and returns an SMTP client connection.
    /// </summary>
    /// <param name="host">The SMTP server host.</param>
    /// <param name="port">The SMTP server port.</param>
    /// <param name="userName">The SMTP username.</param>
    /// <param name="password">The SMTP password.</param>
    /// <returns>An instance of <see cref="SmtpClient"/>.</returns>
    public SmtpClient CreateConnection(string? host, int port, string? userName, string? password)
    {
        return new SmtpClient(host, port)
        {
            Credentials = new NetworkCredential(userName, password),
            EnableSsl = true
        };
    }

    /// <summary>
    /// Creates and returns an email message.
    /// </summary>
    /// <param name="yourMailAddress">The sender's email address.</param>
    /// <param name="recipientMailAddress">The recipient's email address.</param>
    /// <param name="subject">The email subject.</param>
    /// <param name="body">The email body.</param>
    /// <param name="attachment">The file path of an attachment (optional).</param>
    /// <returns>An instance of <see cref="MailMessage"/>.</returns>
    public MailMessage BuildMessage(string yourMailAddress, string recipientMailAddress, string subject, string body, string attachment)
    {
        MailMessage message = new MailMessage
        {
            From = new MailAddress(yourMailAddress),
            Subject = subject,
            Body = body
        };

        if (!string.IsNullOrEmpty(attachment))
            message.Attachments.Add(new Attachment(attachment));

        message.To.Add(recipientMailAddress);

        return message;
    }

    /// <summary>
    /// Sends an email message using the specified SMTP client.
    /// </summary>
    /// <param name="client">The SMTP client.</param>
    /// <param name="message">The email message to be sent.</param>
    public void DispatchEmail(MailMessage message) => _client.Send(message);

    /// <summary>
    /// Sends a confirmation email with a verification code.
    /// </summary>
    /// <param name="client">The SMTP client.</param>
    /// <param name="yourMailAddress">The sender's email address.</param>
    /// <param name="recipientMailAddress">The recipient's email address.</param>
    /// <param name="code">The verification code.</param>
    public void DispatchConfirmEmail(string yourMailAddress, string recipientMailAddress, string code)
    {
        this.DispatchEmail(BuildMessage(
            yourMailAddress,
            recipientMailAddress,
            "Código de verificação para Login",
            $"Introduza o código {code}. Este código só é válido quando utilizado com o endereço de e-mail que recebeu o código de verificação.",
            ""
            ));
    }
}