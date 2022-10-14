namespace GradimoZajedno.Core.Extensions;

using Umbraco.Cms.Core.Models.PublishedContent;
using GradimoZajedno.Core.ViewModels.Pages;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Models.DocumentTypes;
using GradimoZajedno.Models.Generated;

public static class ViewModelExtensions
{
    public static ImageViewModel ToViewModel(this Image image)
        => image != null ? new ImageViewModel(image) : default(ImageViewModel);

    public static ImageViewModel TryCreateImageViewModel(this IPublishedContent content)
    {
        return (content as Image)?.ToViewModel();
    }

    public static XMLSitemapItemViewModel ToViewModel(this ISeo page)
        => page != null ? new XMLSitemapItemViewModel(page) : default;

}