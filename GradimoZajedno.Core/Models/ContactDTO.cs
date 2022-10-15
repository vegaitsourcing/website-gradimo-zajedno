namespace GradimoZajedno.Core.Models;

public class ContactDTO
{
    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Telephone { get; set; } = null!;
    public string Message { get; set; } = null!;

    public bool IsValid => !string.IsNullOrWhiteSpace(Name)
            && !string.IsNullOrWhiteSpace(LastName)
            && !string.IsNullOrWhiteSpace(Email)
            && !string.IsNullOrWhiteSpace(Message);
}
