namespace GradimoZajedno.Core.Extensions;

using Microsoft.AspNetCore.Http;
using GradimoZajedno.Common;

public static class HttpRequestExtensions
{
    public static string GetQueryParameter(this HttpRequest request)
    {
        if (request == null) return string.Empty;

        return request.Query[Constants.RequestParameters.Query];
    }

    public static int GetPageParameter(this HttpRequest request)
    {
        const int defaultValue = 1;
        if (request == null) return defaultValue;

        return int.TryParse(request.Query[Constants.RequestParameters.Page], out int page) ? page : defaultValue;
    }
}
