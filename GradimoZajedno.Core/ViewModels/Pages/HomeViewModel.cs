namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;

public class HomeViewModel : PageViewModel
{
    public HomeViewModel(IPageContext<Home> context) : base(context)
    {
    }
	}
