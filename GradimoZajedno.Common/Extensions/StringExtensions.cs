namespace GradimoZajedno.Common.Extensions;

using Newtonsoft.Json;
using System;
using System.Text;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    /// <summary>
    /// Removes (at most one instance of) the <paramref name="removeString"/> string from the end of the <paramref name="source"/> string.
    /// </summary>
    /// <param name="source">The source string.</param>
    /// <param name="removeString">String to remove from the <paramref name="source"/>.</param>
    /// <param name="comparisonType">Determines how <paramref name="source"/> and <paramref name="removeString"/> strings are compared to each other.</param>
    /// <returns><paramref name="source"/> string without <paramref name="removeString"/> at the end.</returns>
    public static string RemoveSuffix(this string source, string removeString, StringComparison comparisonType = StringComparison.CurrentCulture)
    {
        if (string.IsNullOrWhiteSpace(removeString)) return source;

        if (source.EndsWith(removeString, comparisonType))
        {
            source = source.Remove(source.Length - removeString.Length);
        }

        return source;
    }


    public static string GenerateSlug(this string value) {
          //First to lower case
        value = value.ToLowerInvariant();

        //Remove all accents
        var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);
        value = Encoding.ASCII.GetString(bytes);

        //Replace spaces
        value = Regex.Replace(value, @"\s", "-", RegexOptions.Compiled);

        //Remove invalid chars
        value = Regex.Replace(value, @"[^a-z0-9\s-_]", "",RegexOptions.Compiled);

        //Trim dashes from end
        value = value.Trim('-', '_');

        //Replace double occurences of - or _
        value = Regex.Replace(value, @"([-_]){2,}", "$1", RegexOptions.Compiled);

        return value ;
    }

    public static T? TryToDeserializeJson<T>(this string json)
    {
        try
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        catch (Exception)
        {
            //ignore
        }

        return default;
    }

    public static string ReplaceNewLinesWithLineBreaks(this string source)
        => source
                ?.Replace("\n\r", "<br/>")
                .Replace("\n", "<br/>")
                .Replace("\r", "<br/>")
                ?? string.Empty;
}
