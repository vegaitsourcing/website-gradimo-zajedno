namespace GradimoZajedno.Core.Attributes;

using System;
using System.Linq;
using Umbraco.Cms.Core.Models.PublishedContent;
using GradimoZajedno.Models.Generated;
using Microsoft.AspNetCore.Mvc.Filters;
using Umbraco.Cms.Core.Web;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ExternalRedirectAttribute : ActionFilterAttribute
{
	private readonly IUmbracoContextAccessor _umbracoContextAccessor;
	public ExternalRedirectAttribute(IUmbracoContextAccessor umbracoContextAccessor)
	{
		_umbracoContextAccessor = umbracoContextAccessor ?? throw new ArgumentNullException(nameof(umbracoContextAccessor));
	}
	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		var currentUrl = filterContext.HttpContext.Request.Path;
		if (!currentUrl.HasValue) return;
		_umbracoContextAccessor.TryGetUmbracoContext(out IUmbracoContext umbracoContext);

		var rootPage = umbracoContext
			.Content
			.GetAtRoot()
			.FirstOrDefault(rp => currentUrl.Value.StartsWith(rp.Url(mode: UrlMode.Absolute)));
		if (rootPage == null) return;
		var page = umbracoContext
				.Content
				.GetByRoute($"{rootPage.Id}{currentUrl.Value}")
			as IPage;
		if (string.IsNullOrWhiteSpace(page?.ExternalRedirect)) return;
		filterContext.HttpContext.Response.Redirect(page.ExternalRedirect);
	}
}