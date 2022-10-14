using GradimoZajedno.Models.Generated;

namespace GradimoZajedno.Core.Contexts;

public interface IPageContext<out T> : ISiteContext where T : class, IPage
{
    T Page { get; }
}
