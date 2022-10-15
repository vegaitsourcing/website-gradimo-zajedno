namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;
using GradimoZajedno.Core.ViewModels.Shared;
using GradimoZajedno.Core.Extensions;

public class ContactViewModel : PageViewModel
{
    public ContactViewModel(IPageContext<Contact> context) : base(context)
    {
        Image = context.Page.ContactPicture?.Content.TryCreateImageViewModel();
    }
    public ImageViewModel Image { get;set;}
}
