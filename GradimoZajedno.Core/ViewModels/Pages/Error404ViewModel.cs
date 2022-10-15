namespace GradimoZajedno.Core.ViewModels.Pages;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;

public class Error404ViewModel : PageViewModel
{
    public Error404ViewModel(IPageContext<Error404> context) : base(context)
    {
        this.Title = context.Page.Title;
        this.Text = context.Page.Text;
    }

    public string Title {get;set;}

    public string Text {get; set;}
}
