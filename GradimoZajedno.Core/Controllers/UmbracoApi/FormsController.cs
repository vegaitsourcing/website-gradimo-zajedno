using GradimoZajedno.Core.Models;
using GradimoZajedno.Core.Services;
using GradimoZajedno.Models.Generated;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace GradimoZajedno.Core.Controllers.UmbracoApi;

[Route("[controller]/[action]")]
public class FormsController : UmbracoApiController
{
    private readonly IUmbracoContextFactory _context;
    private readonly ILocalizationService _textService;
    private readonly EmailService _emailService;
    private readonly IContentService _contentService;

    public FormsController(EmailService emailService, IUmbracoContextFactory contextFactory, ILocalizationService textService, IContentService contentService)
    {
        _emailService = emailService;
        _context = contextFactory;
        _textService = textService;
        _contentService = contentService;
    }

    [HttpPost]
    public async Task<IActionResult> ContactAsync([FromBody]ContactFormDTO contactForm)
    {
        if (!contactForm.IsValid)
        {
            return BadRequest();
        }
        var templateMessage = @$"Ime: {contactForm.Name}
Prezime: {contactForm.LastName}
Telefon: {contactForm.Telephone}
Poruka:
{contactForm.Message}
";
        await _emailService.SendAsync(from: contactForm.Email, message: templateMessage, subject: $"Novi zahtev za kontakt sa web sajta");
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> BuyAsync([FromBody]BuyFormDto buyForm)
    {
        if (!buyForm.IsValid)
        {
            return BadRequest();
        }

        var templateMessage = @$"Ime: {buyForm.Name}
Prezime: {buyForm.LastName}
Telefon: {buyForm.Telephone}
";
        await _emailService.SendAsync(from: buyForm.Email, message: templateMessage, subject: "Novi zahtev za kupovinu sa web sajta");
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> TimeCapsuleAsync([FromBody]TimeCapsuleFormDto timeCapsuleForm)
    {
        if (!timeCapsuleForm.IsValid)
        {
            return BadRequest();
        }

        var templateMessage = @$"Ime: {timeCapsuleForm.Name}
Prezime: {timeCapsuleForm.LastName}
Priča:
{timeCapsuleForm.Story}
";
        await _emailService.SendAsync(from: timeCapsuleForm.Email, message: templateMessage, subject: "Novi zahtev za kupovinu sa web sajta");
        CreateStory(timeCapsuleForm);
        return Ok();
    }

    private void CreateStory(TimeCapsuleFormDto form)
    {
        using var cref = _context.EnsureUmbracoContext();
        var language = _textService.GetLanguageByIsoCode("sr-Latn-RS");
        if (!string.IsNullOrEmpty(form.Language) && form.Language.Equals("en"))
        {
            language = _textService.GetLanguageByIsoCode("en-US");
        }

        var homeNode = cref.UmbracoContext.Content
                            .GetAtRoot(language.IsoCode)
                            .Where(e => e.Cultures.ContainsKey(language.IsoCode))
                            .FirstOrDefault(x => x.ContentType.Alias == Home.ModelTypeAlias);
        var parent = homeNode.Descendants<TimeCapsule>(language.IsoCode).FirstOrDefault();

        var story = _contentService.Create("Nova prica", parent.Id, Story.ModelTypeAlias);
        story.SetCultureName("Nova prica", language.IsoCode);
        story.SetValue("firstName", form.Name, language.IsoCode);
        story.SetValue("lastName", form.LastName, language.IsoCode);
        story.SetValue("email", form.Email, language.IsoCode);
        story.SetValue("text", form.Story, language.IsoCode);

        _contentService.Save(story);
    }
}
