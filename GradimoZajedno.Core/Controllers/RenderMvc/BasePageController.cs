namespace GradimoZajedno.Core.Controllers.RenderMvc;

using GradimoZajedno.Core.Contexts;
using GradimoZajedno.Models.Generated;
using Umbraco.Cms.Core.Web;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Web.Common.Controllers;
using Microsoft.AspNetCore.Mvc.ViewEngines;

public abstract class BasePageController<T> : RenderController where T : class, IPage
{
    protected BasePageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
    }

    protected IPageContext<T> CreatePageContext(T page)
    {
        return new PageContext<T>(page, CurrentPage);
    }
}
