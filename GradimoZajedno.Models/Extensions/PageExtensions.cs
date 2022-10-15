namespace GradimoZajedno.Models.Extensions;
using GradimoZajedno.Models.Generated;

public static class PageExtensions
{
    public static string PageTitle(this IPage page)
    {
        return page.Name;
    }

    public static bool IsHome(this IPage page)
    {
        return page.ContentType.Alias.Equals(Home.ModelTypeAlias);
    }
}