namespace GradimoZajedno.Models.DocumentTypes;

using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Models;

public interface ISeo : IPublishedContent
{
    string SeoTitle { get; }
    string SeoDescription { get; }
    string SeoKeywords { get; }
    bool HideFromSearchEngines { get; }
    string SitemapChangeFrequency { get; }
    string SitemapPriority { get; }
    IEnumerable<string> AlternateLanguages { get; }
    Link CanonicalLink { get; }
}