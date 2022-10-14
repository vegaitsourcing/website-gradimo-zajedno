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
	// Mixin Content Type with alias "siteSettings"
	/// <summary>Site Settings</summary>
	public partial interface ISiteSettings : IPublishedContent
	{
		/// <summary>Canonical domain</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CanonicalDomain { get; }

		/// <summary>Cookie script</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CookieScript { get; }

		/// <summary>Google analytics script code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GoogleAnalyticsScriptCode { get; }

		/// <summary>Google tag manager non script code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GoogleTagManagerNonScriptCode { get; }

		/// <summary>Google tag manager script code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GoogleTagManagerScriptCode { get; }

		/// <summary>Hide all pages from search engines</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		bool HideAllPagesFromSearchEngines { get; }

		/// <summary>Robots</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Robots { get; }

		/// <summary>Site name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SiteName { get; }
	}

	/// <summary>Site Settings</summary>
	[PublishedModel("siteSettings")]
	public partial class SiteSettings : PublishedContentModel, ISiteSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public new const string ModelTypeAlias = "siteSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SiteSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SiteSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Canonical domain
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("canonicalDomain")]
		public virtual string CanonicalDomain => GetCanonicalDomain(this, _publishedValueFallback);

		/// <summary>Static getter for Canonical domain</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCanonicalDomain(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "canonicalDomain");

		///<summary>
		/// Cookie script
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cookieScript")]
		public virtual string CookieScript => GetCookieScript(this, _publishedValueFallback);

		/// <summary>Static getter for Cookie script</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCookieScript(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "cookieScript");

		///<summary>
		/// Google analytics script code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleAnalyticsScriptCode")]
		public virtual string GoogleAnalyticsScriptCode => GetGoogleAnalyticsScriptCode(this, _publishedValueFallback);

		/// <summary>Static getter for Google analytics script code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGoogleAnalyticsScriptCode(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "googleAnalyticsScriptCode");

		///<summary>
		/// Google tag manager non script code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleTagManagerNonScriptCode")]
		public virtual string GoogleTagManagerNonScriptCode => GetGoogleTagManagerNonScriptCode(this, _publishedValueFallback);

		/// <summary>Static getter for Google tag manager non script code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGoogleTagManagerNonScriptCode(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "googleTagManagerNonScriptCode");

		///<summary>
		/// Google tag manager script code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("googleTagManagerScriptCode")]
		public virtual string GoogleTagManagerScriptCode => GetGoogleTagManagerScriptCode(this, _publishedValueFallback);

		/// <summary>Static getter for Google tag manager script code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGoogleTagManagerScriptCode(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "googleTagManagerScriptCode");

		///<summary>
		/// Hide all pages from search engines
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[ImplementPropertyType("hideAllPagesFromSearchEngines")]
		public virtual bool HideAllPagesFromSearchEngines => GetHideAllPagesFromSearchEngines(this, _publishedValueFallback);

		/// <summary>Static getter for Hide all pages from search engines</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public static bool GetHideAllPagesFromSearchEngines(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "hideAllPagesFromSearchEngines");

		///<summary>
		/// Robots
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("robots")]
		public virtual string Robots => GetRobots(this, _publishedValueFallback);

		/// <summary>Static getter for Robots</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetRobots(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "robots");

		///<summary>
		/// Site name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteName")]
		public virtual string SiteName => GetSiteName(this, _publishedValueFallback);

		/// <summary>Static getter for Site name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSiteName(ISiteSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "siteName");
	}
}
