namespace GradimoZajedno.Core.ViewModels.Shared;

using Umbraco.Cms.Core.Models;
using GradimoZajedno.Models.Generated;

public class LinkViewModel
{
    public LinkViewModel(string url, string content, string target = null)
    {
        Url = url;
        Content = content;
        Target = target;
    }

    public LinkViewModel(Link link) : this(link.Url, link.Name, link.Target)
    { }

    public LinkViewModel(IPage node, string target = null) : this(node.Url(), node.PageTitle, target)
    { }

    public string Url { get; }
    
    public string Content { get; }

    public string Target { get; }
}
