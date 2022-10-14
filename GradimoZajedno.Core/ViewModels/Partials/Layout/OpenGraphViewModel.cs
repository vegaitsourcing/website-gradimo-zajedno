namespace GradimoZajedno.Core.ViewModels.Partials.Layout;

using System;
using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Core.Extensions;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Models.DocumentTypes;
using GradimoZajedno.Models.Extensions;
using GradimoZajedno.Models.Generated;

public class OpenGraphViewModel
{
    public OpenGraphViewModel(IPageContext<IPage> context, ISeo seo)
    {
        if (context == null) throw new ArgumentNullException(nameof(context));
        if (seo == null) throw new ArgumentNullException(nameof(seo));

        Title = GetTitle(context.Page);
        Description = GetDescription(context.Page);
        Image = context.Page.OpenGraphImage?.Content.TryCreateImageViewModel();
        CanonicalUrl = seo.GetCanonicalUrl(context.SiteSettings.CanonicalDomain);
        Locale = context.Page.GetCultureFromDomains();
        SiteName = context.SiteSettings.SiteName;
    }

    public string Title { get; }
    public string Description { get; }
    public ImageViewModel Image { get; }
    public string CanonicalUrl { get; }
    public string Locale { get; }
    public string SiteName { get; }

    private static string GetTitle(IPage page)
    {
        if (!string.IsNullOrWhiteSpace(page.OpenGraphTitle)) return page.OpenGraphTitle;
        if (!string.IsNullOrWhiteSpace(page.SeoTitle)) return page.SeoTitle;
        if (!string.IsNullOrWhiteSpace(page.PageTitle)) return page.PageTitle;

        return page.Name;
    }

    private static string GetDescription(IPage page)
    {
        if (!string.IsNullOrWhiteSpace(page.OpenGraphDescription)) return page.OpenGraphDescription;

        return page.SeoDescription;
    }
}
