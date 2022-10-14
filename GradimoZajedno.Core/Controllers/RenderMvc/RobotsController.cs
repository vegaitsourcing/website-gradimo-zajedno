namespace GradimoZajedno.Core.Controllers.RenderMvc;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Umbraco.Cms.Core.Web;
using GradimoZajedno.Models.Generated;

public class RobotsController : Controller
{
    private const string RobotsConfigurationOption = "RobotsTxtOption";
    private readonly IWebHostEnvironment _hostingEnvironment;

    private readonly IUmbracoContextFactory _umbracoContextFactory;

    private readonly IConfiguration _configuration;

    public RobotsController(IWebHostEnvironment hostingEnvironment, IUmbracoContextFactory umbracoContextFactory, IConfiguration configuration)
    {
        _hostingEnvironment = hostingEnvironment;
        _umbracoContextFactory = umbracoContextFactory;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        var robotsSourceOption = _configuration[RobotsConfigurationOption];

        if (robotsSourceOption.Equals("File"))
        {
            string path = Path.Combine(_hostingEnvironment.ContentRootPath, "robots.txt");

            if (!System.IO.File.Exists(path))
            {
                throw new FileNotFoundException("Can't find robots.txt");
            }

            return Content(System.IO.File.ReadAllText(path), "text/plain");
        }

        using var contextReference = _umbracoContextFactory.EnsureUmbracoContext();

        var umbracoContext = contextReference.UmbracoContext;
        // Lets try and find the robots file contents from Umbraco.
        var siteSettings = umbracoContext.Content.GetSingleByXPath("//home") as ISiteSettings;

        return Content(siteSettings.Robots, "text/plain");
    }
}