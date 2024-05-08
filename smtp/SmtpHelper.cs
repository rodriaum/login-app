using System.Net.Mail;
using System.Net;

namespace Login.smtp
{
    internal class SmtpHelper
    {
        // Custom Connection
        public static SmtpClient Connection(string? host, int port, string? userName, string? password)
        {
            return new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = true
            };
        }

        // Default Simple Mail Transfer Protocol: Microsoft Outlook
        public static SmtpClient Connection(string? userName, string? password) => Connection("smtp-mail.outlook.com", 587, userName, password);

        // Message Builder
        public static MailMessage Message(string yourMailAddress, string recipientMailAddress, string subject, string body, string attachment)
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

        // Message Mail Builder
        public static void Send(SmtpClient client, MailMessage message) => client.Send(message);

        // Email Confirmer 
        public static void SendConfirmationEmail(SmtpClient client, string yourMailAddress, string recipientMailAddress, string code)
        {
            Send(client, Message(
                yourMailAddress,
                recipientMailAddress,
                "Código de verificação para Login",
                $"Introduza o código {code}. Este código só é válido quando utilizado com o endereço de e-mail que recebeu o código de verificação.",
                ""
                ));
        }
    }
}
