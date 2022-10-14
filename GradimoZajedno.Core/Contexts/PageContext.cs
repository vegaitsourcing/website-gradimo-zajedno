namespace GradimoZajedno.Core.Contexts;

using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using GradimoZajedno.Models.Generated;

public class PageContext<T> : SiteContext, IPageContext<T> where T : class, IPage
{
    public PageContext(T page, IPublishedContent? publishedContent) : base(publishedContent)
    {
        Page = page ?? throw new ArgumentNullException(nameof(page));
    }

    public T Page { get; }
}