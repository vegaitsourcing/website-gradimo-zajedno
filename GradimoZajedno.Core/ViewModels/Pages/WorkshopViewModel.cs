namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Core.Extensions;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Models.Generated;

public class WorkshopViewModel : PageViewModel
{
    public WorkshopViewModel(IPageContext<Workshop> context) : base(context)
    {
        this.WorkshopTitle = context.Page.WorkshopTitle;
        this.WorkshopDate = context.Page.WorkshopDate.ToString("dd. MMMM yyyy");
        this.WorkshopDateShort = context.Page.WorkshopDate.ToString("yyyy-MM-dd");

        this.WorkshopText = context.Page.WorkshopText;
        this.Picture1 = context.Page.WorkshopPicture1?.Content.TryCreateImageViewModel();
        this.Picture2 = context.Page.WorkshopPicture2?.Content.TryCreateImageViewModel();
    }

    public string WorkshopTitle {get;set;}
    public string WorkshopDate {get;set;}

    public string WorkshopDateShort {get; set;}
    public string WorkshopText {get;set;}

    public ImageViewModel Picture1 {get;set;}
    public ImageViewModel Picture2 {get;set;}
}