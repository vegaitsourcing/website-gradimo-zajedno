namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;

public class CityViewModel : PageViewModel
{
    public CityViewModel(IPageContext<City> context) : base(context)
    {
        var settlement = context.Page.CurrentSettlement as Settlement;
        Title = context.Page.Title;
        Description = settlement.Description;
        this.CurrentSettlement = settlement;
    }

    public string Description {get;set;}

    public string Title {get;set;}
    
    public Settlement CurrentSettlement {get;set;}
}
