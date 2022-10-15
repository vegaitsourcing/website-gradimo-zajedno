using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using GradimoZajedno.Models.Generated;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Models;

[Route("buildings/[action]")]
public class BuildingsController : UmbracoApiController
{
    private readonly IUmbracoContextFactory _context;
    private readonly ILocalizationService _textService;

    public BuildingsController(IUmbracoContextFactory contextFactory, ILocalizationService textService)
    {
        _context = contextFactory;
        _textService = textService;
    }

    public SettlementDTO GetAllSettlementBuildings(string lang)
    {
        using var cref = _context.EnsureUmbracoContext();
        var language = _textService.GetLanguageByIsoCode("sr-Latn-RS");
        if (!string.IsNullOrEmpty(lang) && lang.Equals("en"))
        {
            language = _textService.GetLanguageByIsoCode("en-US");
        }

        var homeNode = cref.UmbracoContext.Content.GetAtRoot(language.IsoCode).Where(e => e.Cultures.ContainsKey(language.IsoCode)).FirstOrDefault(x => x.ContentType.Alias == Home.ModelTypeAlias);
        var cityNode = homeNode.Descendants<City>(language.IsoCode).FirstOrDefault();
        var currentSettlement = cref.UmbracoContext.Content.GetById(cityNode.CurrentSettlement.Id);

        var retVal = new SettlementDTO();

        retVal.CloseBtn = GetTranslation("Form.Close", language);
        retVal.FiltersBtn = GetTranslation("Quarter.Filters", language);

        retVal.FilterBottom.Add(new TagFilterDTO(GetTranslation("Quarters.All", language), true));
        retVal.FilterBottom.Add(new TagFilterDTO(GetTranslation("Building.SignificantObject", language)));
        retVal.FilterBottom.Add(new TagFilterDTO(GetTranslation("Building.OnSale", language)));
        retVal.FilterBottom.Add(new TagFilterDTO(GetTranslation("Building.Sold", language)));

        foreach (var quarter in currentSettlement.Descendants<Quarter>(language.IsoCode))
        {
            retVal.FilterTop.Add(new QuarterDTO(quarter.Title));

            foreach (var building in quarter.Descendants<Building>(language.IsoCode))
            {
                var buildingDTO = new BuildingDTO();
                buildingDTO.Object = building.Title;
                buildingDTO.Img = building.Image?.MediaUrl();
                buildingDTO.Location = quarter.Title;
                buildingDTO.NameLabel = GetTranslation("Building.Builder", language);
                buildingDTO.NameSurname = building.Builder;
                buildingDTO.PriceTag = GetTranslation("Building.Price", language);
                buildingDTO.Btn = GetTranslation("Building.BuyButton", language);
                buildingDTO.Url = building.Url(language.IsoCode);
                buildingDTO.Text = building.Description;
                buildingDTO.Price = building.Price;

                if (!building.IsSold)
                {
                    buildingDTO.Tag.Add(new BuildingTagDTO()
                    {
                        Class = "green",
                        Name = GetTranslation("Building.OnSale", language)
                    });
                }
                else
                {
                    buildingDTO.Tag.Add(new BuildingTagDTO()
                    {
                        Class = "red",
                        Name = GetTranslation("Building.Sold", language)
                    });
                }

                if (building.ImportantObject)
                {
                    buildingDTO.Tag.Add(new BuildingTagDTO()
                    {
                        Class = "gold",
                        Name = GetTranslation("Building.SignificantObject", language)
                    });
                }

                retVal.Item.Add(buildingDTO);
            }
        }

        return retVal;
    }

    private string GetTranslation(string key, ILanguage language)
    {
        var dictionaryItem = _textService.GetDictionaryItemByKey(key);
        if (dictionaryItem == null)
        {
            return key;
        }

        return dictionaryItem.GetTranslatedValue(language.Id);
    }
}
