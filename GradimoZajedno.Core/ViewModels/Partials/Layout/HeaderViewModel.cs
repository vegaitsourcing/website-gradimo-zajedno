namespace GradimoZajedno.Core.ViewModels.Partials.Layout;

using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Models;
using GradimoZajedno.Core.Extensions;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Models.Generated;

public class HeaderViewModel
{
    public HeaderViewModel(IHeader header)
    {
        if (header == null) throw new ArgumentNullException(nameof(header));

        Logo = header.Logo?.Content.TryCreateImageViewModel();
        var homeNode = ((PublishedContentModel)header).AncestorOrSelf<Home>();
        LogoUrl = homeNode.Url();

        NavigationMenu = header.NavigationMenu.Select(link => link.ToViewModel());

    }

    public ImageViewModel Logo { get; }
    public string LogoUrl { get; }
    public IEnumerable<LinkViewModel> NavigationMenu { get; }
}
