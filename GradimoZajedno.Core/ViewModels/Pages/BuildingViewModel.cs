namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Core.Extensions;

public class BuildingViewModel : PageViewModel
{
    public BuildingViewModel(IPageContext<Building> context) : base(context)
    {
        var quarter = context.Page.Parent as Quarter;
        var settlement = quarter.Parent as Settlement;
        var city = settlement.Parent as City;

        Title = context.Page.Title;
    
        Image = context.Page.Image?.Content.TryCreateImageViewModel();

        Location = quarter.Title;
        CityName = city.Title;
        CityUrl = city.Url();
        
        Description = context.Page.Description;
        Price = context.Page.Price;
        Builder = context.Page.Builder;
        Owner = context.Page.Owner;
        ImportantObject = context.Page.ImportantObject;
        IsSold = context.Page.IsSold;
    }

    public string Title {get;set;}

    public string Location {get;set;}

    public string CityName {get;set;}

    public string CityUrl {get;set;}

    public ImageViewModel Image { get;set;}

    public string Description {get;set;}

    public string Price {get;set;}

    public string Builder {get;set;}

    public string Owner {get;set;}

    public bool ImportantObject {get;set;}

    public bool IsSold {get;set;}
}
