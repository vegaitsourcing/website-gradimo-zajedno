namespace GradimoZajedno.Core.ViewModels.Partials.Layout;

using System;
using System.Collections.Generic;
using System.Linq;
using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Models.DocumentTypes;
using GradimoZajedno.Models.Extensions;
using Umbraco.Cms.Core.Models.PublishedContent;

public class MetaTagsViewModel
{
    public MetaTagsViewModel(ISeoContext<ISeo> context)
    {
        if (context == null) throw new ArgumentNullException(nameof(context));

        Title = context.Seo.GetFormattedSeoTitle(context.CurrentPage, context.SiteSettings.SiteName);
        Description = context.Seo.SeoDescription;
        Keywords = context.Seo.SeoKeywords;
        CanonicalLink = context.Seo.GetCanonicalUrl(context.SiteSettings.CanonicalDomain);
        AlternateLanguageLinks = context.Seo.AlternateLanguages?.Select(al => new AlternateLinkViewModel(al, context.CurrentPage.Url(mode: UrlMode.Absolute))).ToList();
        HideFromSearchEngines = context.SiteSettings.HideAllPagesFromSearchEngines || context.Seo.HideFromSearchEngines;
        SitemapChangeFrequency = context.Seo.SitemapChangeFrequency;
        SitemapPriority = context.Seo.SitemapPriority;
    }

    public string Title { get; }
    public string Description { get; }
    public string Keywords { get; }
    public string CanonicalLink { get; }
    public IReadOnlyList<AlternateLinkViewModel> AlternateLanguageLinks { get; }

    public bool HideFromSearchEngines { get; }

    public string SitemapChangeFrequency { get; }
    public string SitemapPriority { get; }
}
