namespace GradimoZajedno.Core.Models;

public class SmtpSettings
{
    public const string SectionName = nameof(SmtpSettings);
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Host { get; set; } = null!;
    public string To { get; set; } = null!;
    public int Port { get; set; }
}
