namespace GradimoZajedno.Core.ViewModels.Partials.Layout;

using System;
using GradimoZajedno.Models.Generated;

public class FooterViewModel
{
    public FooterViewModel(IFooter footer)
    {
        if (footer == null) throw new ArgumentNullException(nameof(footer));

        CopyrightText = footer.CopyrightText;
    }

    public string CopyrightText { get; }
}
