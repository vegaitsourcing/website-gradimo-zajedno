using Microsoft.AspNetCore.Http;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using GradimoZajedno.Core.ViewModels.Pages;
using GradimoZajedno.Models.Generated;
using Microsoft.AspNetCore.Http.Extensions;

public class XmlSitemapService : IXmlSitemapService
{
    private readonly IUmbracoContextFactory _umbracoContextFactory;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IPublishedValueFallback _publishedValueFallback;

    public XmlSitemapService(
        IUmbracoContextFactory umbracoContextFactory,
        IHttpContextAccessor httpContextAccessor,
        IPublishedValueFallback publishedValueFallback)
    {
        _umbracoContextFactory = umbracoContextFactory;
        _httpContextAccessor = httpContextAccessor;
        _publishedValueFallback = publishedValueFallback;
    }

    public XMLSitemapViewModel GetXmlSitemapViewModel()
    {
        return new XMLSitemapViewModel
        {
            SitemapItems = GetSitemapItems(),
            Context = _httpContextAccessor.HttpContext,
            Url = _httpContextAccessor.HttpContext.Request.GetDisplayUrl()
        };
    }

    private List<XMLSitemapItemViewModel> GetSitemapItems()
    {
        var results = GetHomePage();
        return results.Descendants()
                        .Select(result => new XMLSitemapItemViewModel((GradimoZajedno.Models.DocumentTypes.ISeo)result))
                        .ToList();
    }

    private Home GetHomePage()
    {
        using var umbracoContextReference = _umbracoContextFactory.EnsureUmbracoContext();
        var root = umbracoContextReference.UmbracoContext.Content.GetByRoute("/", false);
        return new Home(root, _publishedValueFallback);
    }
}