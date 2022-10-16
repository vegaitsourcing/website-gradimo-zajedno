namespace GradimoZajedno.Core.Controllers.RenderMvc;

using Microsoft.AspNetCore.Mvc;
using GradimoZajedno.Core.ViewModels.Pages;
using GradimoZajedno.Models.Generated;
using Umbraco.Cms.Core.Web;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;

public class TimeCapsuleController : BasePageController<TimeCapsule>
{
    private readonly IPublishedValueFallback _publishedValueFallback;
    public TimeCapsuleController(ILogger<TimeCapsuleController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IPublishedValueFallback publishedValueFallback) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _publishedValueFallback = publishedValueFallback;
    }
    public override IActionResult Index() {
        var model = new TimeCapsule(CurrentPage, _publishedValueFallback);
        return CurrentTemplate(new TimeCapsuleViewModel(CreatePageContext(model)));
    }
}