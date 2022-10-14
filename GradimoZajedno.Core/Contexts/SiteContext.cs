namespace GradimoZajedno.Core.Contexts;

using System;
using GradimoZajedno.Models.Generated;
using Umbraco.Cms.Core.Models.PublishedContent;

public class SiteContext : ISiteContext
{
    public SiteContext(IPublishedContent publishedContent)
    {
        PublishedContent = publishedContent ?? throw new ArgumentNullException(nameof(publishedContent));

        LazyCurrentPage = new Lazy<IPage>(() => publishedContent as IPage);
        LazyHome = new Lazy<Home>(() => publishedContent?.AncestorOrSelf<Home>());
        LazySiteSettings = new Lazy<ISiteSettings>(() => LazyHome.Value);
    }

    public IPage CurrentPage => LazyCurrentPage.Value;

    public Home Home => LazyHome.Value;

    public ISiteSettings SiteSettings => LazySiteSettings.Value;

    protected IPublishedContent PublishedContent { get; }

    private Lazy<IPage> LazyCurrentPage { get; }
    
    private Lazy<Home> LazyHome { get; }

    private Lazy<ISiteSettings> LazySiteSettings { get; }
}
