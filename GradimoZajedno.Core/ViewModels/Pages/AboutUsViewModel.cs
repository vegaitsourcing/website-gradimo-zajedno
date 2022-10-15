namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Core.Extensions;
using GradimoZajedno.Models.Generated;
using GradimoZajedno.Core.ViewModels.Shared;

public class AboutUsViewModel : PageViewModel
{
    public AboutUsViewModel(IPageContext<AboutUs> context) : base(context)
    {
         AboutUsPicture = context.Page.AboutUsPicture?.Content.TryCreateImageViewModel();
         BannerTitle = context.Page.AboutUsBanner[0].Content.Value("title").ToString();
         BannerDescription = context.Page.AboutUsBanner[0].Content.Value("description").ToString();

    }
    public ImageViewModel AboutUsPicture {get;set;}
    public string BannerTitle {get;set;}
    public string BannerDescription {get;set;}
}
