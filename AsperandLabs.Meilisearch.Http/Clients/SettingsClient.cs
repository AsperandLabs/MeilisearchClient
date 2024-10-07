using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;
using AsperandLabs.Meilisearch.Http.Shared;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class SettingsClient
{
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateAll(HttpClient client, string indexName, UpdateSettingsRequest request, CancellationToken token = default)
    {
        var response = client.PatchAsJsonAsync($"/indexes/{indexName}/settings", request, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Reset(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Dictionary
    public static Task<HttpResponseWrapper<List<string>>> GetDictionary(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/dictionary", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateDictionary(HttpClient client, string indexName, List<string> dictionary, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/dictionary", dictionary, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetDictionary(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/dictionary", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //DisplayedAttribute
    public static Task<HttpResponseWrapper<List<string>>> GetDisplayedAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/displayed-attributes", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateDisplayedAttributes(HttpClient client, string indexName, List<string> displayedAttributes, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/displayed-attributes", displayedAttributes, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetDisplayedAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/displayed-attributes", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //DistinctAttribute
    public static Task<HttpResponseWrapper<string>> GetDistinctAttribute(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/distinct-attribute", token);
        return HttpResponseWrapper<string>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateDistinctAttribute(HttpClient client, string indexName, string distinctAttribute, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/distinct-attribute", distinctAttribute, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetDistinctAttribute(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/distinct-attribute", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Faceting
    public static Task<HttpResponseWrapper<FacetingSettings>> GetFaceting(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/faceting", token);
        return HttpResponseWrapper<FacetingSettings>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateFaceting(HttpClient client, string indexName, FacetingSettings facetSettings, CancellationToken token = default)
    {
        var response = client.PatchAsJsonAsync($"/indexes/{indexName}/settings/faceting", facetSettings, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetFaceting(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/faceting", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Filterable Attributes
    public static Task<HttpResponseWrapper<List<string>>> GetFilterableAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/filterable-attributes", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateFilterableAttributes(HttpClient client, string indexName, List<string> filterableAttributes, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/filterable-attributes", filterableAttributes, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetFilterableAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/filterable-attributes", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //l10n
    public static Task<HttpResponseWrapper<LocalizedAttributesSettings>> GetLocalizationAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/localized-attributes", token);
        return HttpResponseWrapper<LocalizedAttributesSettings>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateLocalizationAttributes(HttpClient client, string indexName, LocalizedAttributesSettings localizedAttributesSettings, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/localized-attributes", localizedAttributesSettings, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetLocalizationAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/localized-attributes", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    //Pagination
    public static Task<HttpResponseWrapper<PaginationSettings>> GetPagination(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/pagination", token);
        return HttpResponseWrapper<PaginationSettings>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdatePagination(HttpClient client, string indexName, PaginationSettings paginationSettings, CancellationToken token = default)
    {
        var response = client.PatchAsJsonAsync($"/indexes/{indexName}/settings/pagination", paginationSettings, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetPagination(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/pagination", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    //Todo: continue at https://www.meilisearch.com/docs/reference/api/settings#get-proximity-precision-settings
}