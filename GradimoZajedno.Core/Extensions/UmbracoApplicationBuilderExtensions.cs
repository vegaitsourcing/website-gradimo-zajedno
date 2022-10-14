using Microsoft.AspNetCore.Builder;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

public static partial class UmbracoApplicationBuilderExtensions
{
  public static IUmbracoEndpointBuilderContext UseCustomRoutingRules(this IUmbracoEndpointBuilderContext app)
  {
      app.EndpointRouteBuilder.MapControllerRoute(
        "XmlSitemap",
        "sitemap.xml",
        new
        {
            controller = "XmlSitemap",
            action = "Index"
        });

      app.EndpointRouteBuilder.MapControllerRoute(
        "Robots",
        "robots.txt",
        new
        {
            controller = "Robots",
            action = "Index"
        });

      return app;
  }
}