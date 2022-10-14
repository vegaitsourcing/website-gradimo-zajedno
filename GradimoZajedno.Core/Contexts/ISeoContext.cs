namespace GradimoZajedno.Core.Contexts;

using GradimoZajedno.Models.DocumentTypes;

public interface ISeoContext<out T> : ISiteContext where T : class, ISeo
{
    T Seo { get; }
}