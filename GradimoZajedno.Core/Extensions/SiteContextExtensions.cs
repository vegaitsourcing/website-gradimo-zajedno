namespace GradimoZajedno.Core.Extensions;
using System;
using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.DocumentTypes;

public static class SiteContextExtensions
{
    public static ISeoContext<T> CreateSeoContext<T>(this ISiteContext context, T seo) where T : class, ISeo
    {
        if (seo == null) return default(ISeoContext<T>);

        return (ISeoContext<T>) Activator.CreateInstance(typeof(SeoContext<>).MakeGenericType(seo.GetType()), seo, context);
    }
}
