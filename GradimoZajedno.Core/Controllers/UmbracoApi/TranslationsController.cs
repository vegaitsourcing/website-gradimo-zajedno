using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;

[Route("translations/[action]")]
public class TranslationsController : UmbracoApiController
{
    private readonly IUmbracoContextFactory _context;

    private readonly ILocalizationService _textService;

    public TranslationsController(IUmbracoContextFactory contextFactory, ILocalizationService textService)
    {
        _context = contextFactory;
        _textService = textService;
    }

    public Dictionary<string, List<Tuple<string, string>>> GetAll()
    {
        using var cref = _context.EnsureUmbracoContext();

        var retVal = new Dictionary<string, List<Tuple<string, string>>>();

        retVal.Add("Building.Sold", GetTranslation("Building.Sold"));

        return retVal;
    }

    private List<Tuple<string, string>> GetTranslation(string key)
    {
        List<Tuple<string, string>> translationDTO = new();

        var dictionaryItem = _textService.GetDictionaryItemByKey(key);
        foreach (var translation in dictionaryItem.Translations)
        {
            translationDTO.Add(new Tuple<string, string>(translation.Language.IsoCode, translation.Value));
        }

        return translationDTO;
    }
}