namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;

public class HomeViewModel : PageViewModel
{
    public Home Home { get; set; }

    public HomeViewModel(IPageContext<Home> context) : base(context)
    {
        Home = context.Home;
    }
}
