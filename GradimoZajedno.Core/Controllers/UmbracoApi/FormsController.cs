using GradimoZajedno.Core.Models;
using GradimoZajedno.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace GradimoZajedno.Core.Controllers.UmbracoApi;

[Route("[controller]/[action]")]
public class FormsController : UmbracoApiController
{
    private readonly EmailService _emailService;

    public FormsController(EmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost]
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

    [HttpPost]
    public async Task<IActionResult> BuyAsync([FromBody]BuyFormDto buyFormValues)
    {
        if (!buyFormValues.IsValid)
        {
            return BadRequest();
        }

        var templateMessage = @$"Ime: {buyFormValues.Name}
Prezime: {buyFormValues.LastName}
Telefon: {buyFormValues.Telephone}
";
        await _emailService.SendAsync(from: buyFormValues.Email, message: templateMessage, subject: "Novi zahtev za kupovinu sa web sajta");
        return Ok();
    }


}
