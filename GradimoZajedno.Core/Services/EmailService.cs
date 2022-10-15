using System.Net;
using System.Net.Mail;
using GradimoZajedno.Core.Models;
using Microsoft.Extensions.Options;

namespace GradimoZajedno.Core.Services;

public class EmailService
{
    private readonly SmtpSettings _smtpSettings;

    public EmailService(IOptions<SmtpSettings> smtpSettings)
    {
        _smtpSettings = smtpSettings.Value;
    }

    public async Task SendAsync(string from, string message, string subject)
    {
        using var email = new MailMessage(from, _smtpSettings.To, subject, message);
        using var smtp = new SmtpClient(_smtpSettings.Host, _smtpSettings.Port)
        {
            Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
            EnableSsl = true
        };
        await smtp.SendMailAsync(email);
    }
}
