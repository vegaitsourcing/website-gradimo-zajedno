public class EmailService {
    public void SendEmail(string message, string subject, string emailTo) {
        using var email = new MailMessage();
        email.Sender = new MailAddress(emailTo);
        email.From = new MailAddress(emailTo);
        email.To.Add(new MailAddress(emailTo));
        email.Subject = subject;
        email.Body = message;

        using var smtp = new SmtpClient();
        smtp.Send(email);
    }
}