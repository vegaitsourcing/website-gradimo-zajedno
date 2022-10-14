namespace GradimoZajedno.Core.Controllers.Surface.Partials;

using Microsoft.AspNetCore.Mvc;
using GradimoZajedno.Core.ViewModels.Partials.Layout;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;

public class LayoutController : BaseSurfaceController
{
    protected LayoutController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
    }
    public ActionResult MetaTags(MetaTagsViewModel viewModel)
        => PartialView(viewModel);

    public ActionResult OpenGraph(OpenGraphViewModel viewModel)
        => PartialView(viewModel);

    public ActionResult Header(HeaderViewModel viewModel)
        => PartialView(viewModel);

    public ActionResult Footer(FooterViewModel viewModel)
        => PartialView(viewModel);
}