//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.2.1+25a20cf
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace GradimoZajedno.Models.Generated
{
	/// <summary>Time Capsule</summary>
	[PublishedModel("timeCapsule")]
	public partial class TimeCapsule : PublishedContentModel, IFooter, IHeader, IPage, ISiteSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public new const string ModelTypeAlias = "timeCapsule";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<TimeCapsule, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public TimeCapsule(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Time Capsule Picture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("timeCapsulePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops TimeCapsulePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "timeCapsulePicture");

		///<summary>
		/// Time Capsule Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("timeCapsuleText")]
		public virtual string TimeCapsuleText => this.Value<string>(_publishedValueFallback, "timeCapsuleText");

		///<summary>
		/// Time Capsule Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("timeCapsuleTitle")]
		public virtual string TimeCapsuleTitle => this.Value<string>(_publishedValueFallback, "timeCapsuleTitle");

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("address")]
		public virtual string Address => global::GradimoZajedno.Models.Generated.Footer.GetAddress(this, _publishedValueFallback);

		///<summary>
		/// Donations
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("donations")]
		public virtual string Donations => global::GradimoZajedno.Models.Generated.Footer.GetDonations(this, _publishedValueFallback);

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("email")]
		public virtual string Email => global::GradimoZajedno.Models.Generated.Footer.GetEmail(this, _publishedValueFallback);

		///<summary>
		/// MenuFirstColumn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("menuFirstColumn")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> MenuFirstColumn => global::GradimoZajedno.Models.Generated.Footer.GetMenuFirstColumn(this, _publishedValueFallback);

		///<summary>
		/// MenuSecondColumn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("menuSecondColumn")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> MenuSecondColumn => global::GradimoZajedno.Models.Generated.Footer.GetMenuSecondColumn(this, _publishedValueFallback);

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("logo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Logo => global::GradimoZajedno.Models.Generated.Header.GetLogo(this, _publishedValueFallback);

		///<summary>
		/// NavigationMenu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("navigationMenu")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> NavigationMenu => global::GradimoZajedno.Models.Generated.Header.GetNavigationMenu(this, _publishedValueFallback);

		///<summary>
		/// Alternate languages
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("alternateLanguages")]
		public virtual global::System.Collections.Generic.IEnumerable<string> AlternateLanguages => global::GradimoZajedno.Models.Generated.Page.GetAlternateLanguages(this, _publishedValueFallback);

		///<summary>
		/// Canonical link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("canonicalLink")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> CanonicalLink => global::GradimoZajedno.Models.Generated.Page.GetCanonicalLink(this, _publishedValueFallback);

		///<summary>
		/// External redirect
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("externalRedirect")]
		public virtual string ExternalRedirect => global::GradimoZajedno.Models.Generated.Page.GetExternalRedirect(this, _publishedValueFallback);

		///<summary>
		/// Hide from navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[ImplementPropertyType("hideFromNavigation")]
		public virtual bool HideFromNavigation => global::GradimoZajedno.Models.Generated.Page.GetHideFromNavigation(this, _publishedValueFallback);

		///<summary>
		/// Hide from search engines
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[ImplementPropertyType("hideFromSearchEngines")]
		public virtual bool HideFromSearchEngines => global::GradimoZajedno.Models.Generated.Page.GetHideFromSearchEngines(this, _publishedValueFallback);

		///<summary>
		/// Navigation title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("navigationTitle")]
		public virtual string NavigationTitle => global::GradimoZajedno.Models.Generated.Page.GetNavigationTitle(this, _publishedValueFallback);

		///<summary>
		/// Open graph description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphDescription")]
		public virtual string OpenGraphDescription => global::GradimoZajedno.Models.Generated.Page.GetOpenGraphDescription(this, _publishedValueFallback);

		///<summary>
		/// Open graph image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OpenGraphImage => global::GradimoZajedno.Models.Generated.Page.GetOpenGraphImage(this, _publishedValueFallback);

		///<summary>
		/// Open graph title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphTitle")]
		public virtual string OpenGraphTitle => global::GradimoZajedno.Models.Generated.Page.GetOpenGraphTitle(this, _publishedValueFallback);

		///<summary>
		/// Page title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::GradimoZajedno.Models.Generated.Page.GetPageTitle(this, _publishedValueFallback);

		///<summary>
		/// SEO description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("SeoDescription")]
		public virtual string SeoDescription => global::GradimoZajedno.Models.Generated.Page.GetSeoDescription(this, _publishedValueFallback);

		///<summary>
		/// SEO keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("SeoKeywords")]
		public virtual string SeoKeywords => global::GradimoZajedno.Models.Generated.Page.GetSeoKeywords(this, _publishedValueFallback);

		///<summary>
		/// SEO title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("SeoTitle")]
		public virtual string SeoTitle => global::GradimoZajedno.Models.Generated.Page.GetSeoTitle(this, _publishedValueFallback);

		///<summary>
		/// Sitemap change frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sitemapChangeFrequency")]
		public virtual string SitemapChangeFrequency => global::GradimoZajedno.Models.Generated.Page.GetSitemapChangeFrequency(this, _publishedValueFallback);

		///<summary>
		/// Sitemap priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sitemapPriority")]
		public virtual string SitemapPriority => global::GradimoZajedno.Models.Generated.Page.GetSitemapPriority(this, _publishedValueFallback);

		///<summary>
		/// Umbraco navigation hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[ImplementPropertyType("umbracoNavigationHide")]
		public virtual bool UmbracoNavigationHide => global::GradimoZajedno.Models.Generated.Page.GetUmbracoNavigationHide(this, _publishedValueFallback);

		///<summary>
		/// Umbraco redirect
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoRedirect")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent UmbracoRedirect => global::GradimoZajedno.Models.Generated.Page.GetUmbracoRedirect(this, _publishedValueFallback);

		///<summary>
		/// Umbraco url alias
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoUrlAlias")]
		public virtual string UmbracoUrlAlias => global::GradimoZajedno.Models.Generated.Page.GetUmbracoUrlAlias(this, _publishedValueFallback);

		///<summary>
		/// Umbraco url name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoUrlName")]
		public virtual string UmbracoUrlName => global::GradimoZajedno.Models.Generated.Page.GetUmbracoUrlName(this, _publishedValueFallback);

		///<summary>
		/// Canonical domain
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("canonicalDomain")]
		public virtual string CanonicalDomain => global::GradimoZajedno.Models.Generated.SiteSettings.GetCanonicalDomain(this, _publishedValueFallback);

		///<summary>
		/// Cookie script
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cookieScript")]
		public virtual string CookieScript => global::GradimoZajedno.Models.Generated.SiteSettings.GetCookieScript(this, _publishedValueFallback);

		///<summary>
		/// Google analytics script code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleAnalyticsScriptCode")]
		public virtual string GoogleAnalyticsScriptCode => global::GradimoZajedno.Models.Generated.SiteSettings.GetGoogleAnalyticsScriptCode(this, _publishedValueFallback);

		///<summary>
		/// Google tag manager non script code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleTagManagerNonScriptCode")]
		public virtual string GoogleTagManagerNonScriptCode => global::GradimoZajedno.Models.Generated.SiteSettings.GetGoogleTagManagerNonScriptCode(this, _publishedValueFallback);

		///<summary>
		/// Google tag manager script code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleTagManagerScriptCode")]
		public virtual string GoogleTagManagerScriptCode => global::GradimoZajedno.Models.Generated.SiteSettings.GetGoogleTagManagerScriptCode(this, _publishedValueFallback);

		///<summary>
		/// Hide all pages from search engines
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[ImplementPropertyType("hideAllPagesFromSearchEngines")]
		public virtual bool HideAllPagesFromSearchEngines => global::GradimoZajedno.Models.Generated.SiteSettings.GetHideAllPagesFromSearchEngines(this, _publishedValueFallback);

		///<summary>
		/// Robots
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("robots")]
		public virtual string Robots => global::GradimoZajedno.Models.Generated.SiteSettings.GetRobots(this, _publishedValueFallback);

		///<summary>
		/// Site name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteName")]
		public virtual string SiteName => global::GradimoZajedno.Models.Generated.SiteSettings.GetSiteName(this, _publishedValueFallback);
	}
}
