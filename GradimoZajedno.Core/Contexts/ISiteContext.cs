namespace GradimoZajedno.Core.Contexts;

using GradimoZajedno.Models.Generated;

public interface ISiteContext
{
    IPage CurrentPage { get; }
    Home Home { get; }
    ISiteSettings SiteSettings { get; }
}