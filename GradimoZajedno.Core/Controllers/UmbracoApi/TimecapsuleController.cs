using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using GradimoZajedno.Models.Generated;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Core.Models.PublishedContent;

[Route("timecapsule/[action]")]
public class TimecapsuleController : UmbracoApiController
{
    private readonly IUmbracoContextFactory _context;
    
    private readonly ILocalizationService _textService;

    private readonly IVariationContextAccessor _variationContextAccessor;

    public TimecapsuleController(IUmbracoContextFactory contextFactory, ILocalizationService textService, IVariationContextAccessor variationContextAccessor)
    {
        _context = contextFactory;
        _textService = textService;
        _variationContextAccessor = variationContextAccessor;
    }

    public List<TimeCapsuleDTO> GetAllStories(string lang)
    {
        using var cref = _context.EnsureUmbracoContext();
        var language = _textService.GetLanguageByIsoCode("sr-Latn-RS");
        if (!string.IsNullOrEmpty(lang) && lang.Equals("en"))
        {
            language = _textService.GetLanguageByIsoCode("en-US");
        }

        _variationContextAccessor.VariationContext = new VariationContext(language.IsoCode);

        var homeNode = cref.UmbracoContext.Content
                            .GetAtRoot(language.IsoCode)
                            .Where(e => e.Cultures.ContainsKey(language.IsoCode))
                            .FirstOrDefault(x => x.ContentType.Alias == Home.ModelTypeAlias);

        var retVal = new List<TimeCapsuleDTO>();

        foreach(var story in homeNode.Descendants<Story>(language.IsoCode)){
            var timecapsuleDTO = new TimeCapsuleDTO();
            timecapsuleDTO.Date = story.CreateDate.ToString("dd.MM.yyyy");
            timecapsuleDTO.Title = story.Title;
            timecapsuleDTO.Text = story.Text;

            retVal.Add(timecapsuleDTO);
        };

        return retVal;
    }
}
