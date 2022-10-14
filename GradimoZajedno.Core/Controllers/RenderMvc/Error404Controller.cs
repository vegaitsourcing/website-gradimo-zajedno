namespace GradimoZajedno.Core.Controllers.RenderMvc;

using System.Net;
using GradimoZajedno.Core.ViewModels.Pages;
using GradimoZajedno.Models.Generated;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Web;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Web.Common.Controllers;
using Microsoft.AspNetCore.Mvc.ViewEngines;

public class Error404Controller : BasePageController<Error404>
{
    public Error404Controller(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
    }
    public ActionResult Error404(Error404 model)
    {
        ControllerContext.HttpContext.Response.StatusCode = (int) HttpStatusCode.NotFound;

        // CurrentTemplate won't work here as this controller may be hit from custom made route
        return View(new Error404ViewModel(CreatePageContext(model)));
    }
}