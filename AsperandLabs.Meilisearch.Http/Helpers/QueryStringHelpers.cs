using System.Collections;
using System.Web;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public class QueryStringHelpers
{
    public static string Create(Dictionary<string, object?> entries)
    {
        var queryParts = entries
            .Where(x => x.Value != null)
            .Select(x => $"{HttpUtility.UrlEncode(x.Key)}={GetQueryStringValue(x.Value!)}")
            .ToList();
        if(queryParts.Count == 0)
            return string.Empty;
        
        return "?" + string.Join("&", queryParts);
    }
    
    private static string GetQueryStringValue(object value)
    {
        var actualValue = value.ToString();
        if(value is IEnumerable enumerable)
            actualValue = string.Join(",", enumerable);
            
        return HttpUtility.UrlEncode(actualValue)!;
    }
}