namespace GradimoZajedno.Core.ViewModels.Pages;

using System.Collections.Generic;
using System.Xml;
using Microsoft.AspNetCore.Http;
using GradimoZajedno.Models.DocumentTypes;

public class XMLSitemapViewModel
{
    public List<XMLSitemapItemViewModel> SitemapItems { get; set; }

    public string Url { get; set; }

    public HttpContext Context { get; internal set; }
}

public class XMLSitemapItemViewModel
{
    public XMLSitemapItemViewModel()
    {
    }

    public XMLSitemapItemViewModel(ISeo page)
    {
        Url = page.Url();
        Date =  XmlConvert.ToString(page.UpdateDate, XmlDateTimeSerializationMode.Utc);
        ChangeFrequency = page.SitemapChangeFrequency;
        Priority = page.SitemapPriority;
    }

    public string Url { get; set; }

    public string Date { get; set; }

    public string Priority { get; set; }

    public string ChangeFrequency { get; set; }
}
