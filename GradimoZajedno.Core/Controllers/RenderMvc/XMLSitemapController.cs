namespace GradimoZajedno.Core.Controllers.RenderMvc;

using Microsoft.AspNetCore.Mvc;

public class XMLSitemapController : Controller
{
    private readonly IXmlSitemapService _xmlSitemapService;

    public XMLSitemapController(IXmlSitemapService xmlSitemapService)
    {
        _xmlSitemapService = xmlSitemapService;
    }

    public ViewResult Index()
    {
        var viewModel = _xmlSitemapService.GetXmlSitemapViewModel();
        return View(viewModel);
    }
}