using System.Web;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public class QueryStringHelpers
{
    public static string Create(Dictionary<string, object?> entries)
    {
        var queryParts = entries
            .Where(x => x.Value != null)
            .Select(x => $"{HttpUtility.UrlEncode(x.Key)}={HttpUtility.UrlEncode(x.Value!.ToString())}")
            .ToList();
        if(queryParts.Count == 0)
            return string.Empty;
        
        return "?" + string.Join("&", queryParts);
    }
}