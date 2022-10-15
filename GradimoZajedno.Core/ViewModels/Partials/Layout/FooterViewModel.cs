namespace GradimoZajedno.Core.ViewModels.Partials.Layout;

using System;
using GradimoZajedno.Models.Generated;
using Umbraco.Cms.Core.Models;
using GradimoZajedno.Core.Extensions;
using GradimoZajedno.Core.ViewModels.Shared;


public class FooterViewModel
{
    public FooterViewModel(IFooter footer)
    {
        if (footer == null) throw new ArgumentNullException(nameof(footer));

        Address = footer.Address;
        Email = footer.Email;
        MenuFirstColumn = footer.MenuFirstColumn.Select(link => link.ToViewModel());
        MenuSecondColumn = footer.MenuSecondColumn.Select(link => link.ToViewModel());
        Donations = footer.Donations;
    }

    public String Address { get; }
    public String Email { get; }
    public IEnumerable<LinkViewModel> MenuFirstColumn { get; }
    public IEnumerable<LinkViewModel> MenuSecondColumn { get; }
    public String Donations { get; }
}
