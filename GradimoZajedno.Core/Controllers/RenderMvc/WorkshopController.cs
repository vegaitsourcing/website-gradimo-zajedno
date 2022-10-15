namespace GradimoZajedno.Core.Controllers.RenderMvc;

using Microsoft.AspNetCore.Mvc;
using GradimoZajedno.Core.ViewModels.Pages;
using GradimoZajedno.Models.Generated;
using Umbraco.Cms.Core.Web;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;

public class WorkshopController : BasePageController<Workshop>
{
    private readonly IPublishedValueFallback _publishedValueFallback;
    public WorkshopController(ILogger<WorkshopController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IPublishedValueFallback publishedValueFallback) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _publishedValueFallback = publishedValueFallback;
    }
    public override IActionResult Index() {
        var model = new Workshop(CurrentPage, _publishedValueFallback);
        return CurrentTemplate(new WorkshopViewModel(CreatePageContext(model)));
    }
}
