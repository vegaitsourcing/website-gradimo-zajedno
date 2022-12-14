namespace GradimoZajedno.Core.ViewModels.Shared;

using Umbraco.Cms.Core.Models.PublishedContent;
using GradimoZajedno.Models.Generated;

public class ImageViewModel
{
    public ImageViewModel()
    {
    }
    public ImageViewModel(string url, string urlAbsolute, string type,
        int width, int height, string? alternateText = null)
    {
        Url = url;
        UrlAbsolute = urlAbsolute;
        Type = type;
        Width = width;
        Height = height;
        AlternateText = alternateText;
    }

    public ImageViewModel(Image image)
        : this(image.Url(), image.MediaUrl(mode: UrlMode.Absolute), image.UmbracoExtension,
                image.UmbracoWidth, image.UmbracoHeight, string.IsNullOrWhiteSpace(image.AlternateText) ? image.Name : image.AlternateText)
    { }

    public string Url { get; }
    public string UrlAbsolute { get; }
    public string Type { get; }
    public int Width { get; }
    public int Height { get; }
    public string AlternateText { get; }
}
