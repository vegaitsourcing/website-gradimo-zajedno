using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;

public class RegisterDependencies : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.AddTransient<IXmlSitemapService, XmlSitemapService>();
    }
}