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
    
    
    //ProximityPrecision
    public static Task<HttpResponseWrapper<GetProximityPrecisionSettings>> GetProximityPrecision(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/proximity-precision", token);
        return HttpResponseWrapper<GetProximityPrecisionSettings>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateProximityPrecision(HttpClient client, string indexName, string proximityPrecision, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/proximity-precision", proximityPrecision, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetProximityPrecision(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/proximity-precision", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Ranking Rules
    public static Task<HttpResponseWrapper<List<string>>> GetRankingRules(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/ranking-rules", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateRankingRules(HttpClient client, string indexName, List<string> rankingRules, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/ranking-rules", rankingRules, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetRankingRules(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/ranking-rules", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Searchable Attributes
    public static Task<HttpResponseWrapper<List<string>>> GetSearchableAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/searchable-attributes", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSearchableAttributes(HttpClient client, string indexName, List<string> searchableAttributes, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/searchable-attributes", searchableAttributes, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSearchableAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/searchable-attributes", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Search Cutoff milliseconds
    public static Task<HttpResponseWrapper<int?>> GetSearchCutoffMilliseconds(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/search-cutoff-ms", token);
        return HttpResponseWrapper<int?>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSearchCutoffMilliseconds(HttpClient client, string indexName, int searchCutoffMilliseconds, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/search-cutoff-ms", searchCutoffMilliseconds, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSearchCutoffMilliseconds(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/search-cutoff-ms", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Separator Tokens
    public static Task<HttpResponseWrapper<List<string>>> GetSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/separator-tokens", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSeparatorTokens(HttpClient client, string indexName, List<string> separatorTokens, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/separator-tokens", separatorTokens, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/separator-tokens", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Non-Separator Tokens
    public static Task<HttpResponseWrapper<List<string>>> GetNonSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/non-separator-tokens", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateNonSeparatorTokens(HttpClient client, string indexName, List<string> nonSeparatorTokens, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/non-separator-tokens", nonSeparatorTokens, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetNonSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/non-separator-tokens", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Sortable Attributes
    public static Task<HttpResponseWrapper<List<string>>> GetSortableAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/sortable-attributes", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSortableAttributes(HttpClient client, string indexName, List<string> sortableAttributes, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/sortable-attributes", sortableAttributes, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSortableAttributes(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/sortable-attributes", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Stop Words
    public static Task<HttpResponseWrapper<List<string>>> GetStopWords(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/stop-words", token);
        return HttpResponseWrapper<List<string>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateStopWords(HttpClient client, string indexName, List<string> stopWords, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/stop-words", stopWords, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetStopWords(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/stop-words", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Synonyms
    public static Task<HttpResponseWrapper<Dictionary<string, List<string>>>> GetSynonyms(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}/settings/synonyms", token);
        return HttpResponseWrapper<Dictionary<string, List<string>>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSynonyms(HttpClient client, string indexName, Dictionary<string, List<string>> synonyms, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/settings/synonyms", synonyms, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSynonyms(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings/synonyms", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    
    //Typo tolerance
    public static Task<HttpResponseWrapper<TypoToleranceSettings>> GetTypoTolerance(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<TypoToleranceSettings>($"/indexes/{indexName}/settings/typo-tolerance", token);
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateTypoTolerance(HttpClient client, string indexName, TypoToleranceSettings settings, CancellationToken token = default) =>
        client.PatchResponseAsync<MeilisearchTask, TypoToleranceSettings>($"/indexes/{indexName}/settings/typo-tolerance", settings, token);
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetTypoTolerance(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/typo-tolerance", token);
    
    
    //Embedders
    //TODO: This needs some extra reading
    //https://www.meilisearch.com/docs/reference/api/settings#embedders-experimental
}