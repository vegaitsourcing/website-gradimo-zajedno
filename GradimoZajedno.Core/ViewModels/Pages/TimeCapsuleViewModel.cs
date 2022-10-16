namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Core.Extensions;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Models.Generated;

public class TimeCapsuleViewModel : PageViewModel
{
    public TimeCapsuleViewModel(IPageContext<TimeCapsule> context) : base(context)
    {
        this.TimeCapsuleTitle = context.Page.TimeCapsuleTitle;
        this.ButtonTitle = (context.Page.Value("timelineButton") as Umbraco.Cms.Core.Models.Link).Name;
        this.TimeCapsuleText = context.Page.TimeCapsuleText;
        TimeCapsulePicture = context.Page.TimeCapsulePicture?.Content.TryCreateImageViewModel();
        
    }
    public string TimeCapsuleTitle {get;set;}
    public string ButtonTitle {get;set;}
    public string TimeCapsuleText {get;set;}
    public ImageViewModel TimeCapsulePicture {get;set;}
}