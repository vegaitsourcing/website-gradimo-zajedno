using GradimoZajedno.Core.Models;
using GradimoZajedno.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace GradimoZajedno.Core.Controllers.UmbracoApi;

[Route("forms")]
public class FormsController : UmbracoApiController
{
    private readonly EmailService _emailService;

    public FormsController(EmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost("contact")]
    public async Task<IActionResult> ContactAsync([FromBody]ContactDTO contact)
    {
        if (!contact.IsValid)
        {
            return BadRequest();
        }
        var templateMessage = @$"Ime: {contact.Name}
Prezime: {contact.LastName}
Telefon: {contact.Telephone}
Poruka:
{contact.Message}
";
        await _emailService.SendAsync(from: contact.Email, message: templateMessage, subject: $"Novi zahtev za kontakt sa web sajta");
        return Ok();
    }
}
