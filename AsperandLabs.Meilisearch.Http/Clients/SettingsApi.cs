using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;
using AsperandLabs.Meilisearch.Http.Shared;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class SettingsApi
{
    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateAll(HttpClient client, string indexName, UpdateSettingsRequest request, CancellationToken token = default) =>
        client.PatchResponseAsync<MeilisearchTask, UpdateSettingsRequest>($"/indexes/{indexName}/settings", request, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> Reset(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings", token);


    //Dictionary
    public static Task<HttpResponseWrapper<List<string>>> GetDictionary(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/dictionary", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateDictionary(HttpClient client, string indexName, List<string> dictionary, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/dictionary", dictionary, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetDictionary(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/dictionary", token);


    //DisplayedAttribute
    public static Task<HttpResponseWrapper<List<string>>> GetDisplayedAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/displayed-attributes", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateDisplayedAttributes(HttpClient client, string indexName, List<string> displayedAttributes, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/displayed-attributes", displayedAttributes, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetDisplayedAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/displayed-attributes", token);


    //DistinctAttribute
    public static Task<HttpResponseWrapper<string>> GetDistinctAttribute(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<string>($"/indexes/{indexName}/settings/distinct-attribute", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateDistinctAttribute(HttpClient client, string indexName, string distinctAttribute, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, string>($"/indexes/{indexName}/settings/distinct-attribute", distinctAttribute, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetDistinctAttribute(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/distinct-attribute", token);


    //Faceting
    public static Task<HttpResponseWrapper<FacetingSettings>> GetFaceting(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<FacetingSettings>($"/indexes/{indexName}/settings/faceting", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateFaceting(HttpClient client, string indexName, FacetingSettings facetSettings, CancellationToken token = default) =>
        client.PatchResponseAsync<MeilisearchTask, FacetingSettings>($"/indexes/{indexName}/settings/faceting", facetSettings, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetFaceting(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/faceting", token);


    //Filterable Attributes
    public static Task<HttpResponseWrapper<List<string>>> GetFilterableAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/filterable-attributes", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateFilterableAttributes(HttpClient client, string indexName, List<string> filterableAttributes, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/filterable-attributes", filterableAttributes, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetFilterableAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/filterable-attributes", token);


    //l10n
    public static Task<HttpResponseWrapper<LocalizedAttributesSettings>> GetLocalizationAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<LocalizedAttributesSettings>($"/indexes/{indexName}/settings/localized-attributes", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateLocalizationAttributes(HttpClient client, string indexName, LocalizedAttributesSettings localizedAttributesSettings, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, LocalizedAttributesSettings>($"/indexes/{indexName}/settings/localized-attributes", localizedAttributesSettings, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetLocalizationAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/localized-attributes", token);

    //Pagination
    public static Task<HttpResponseWrapper<PaginationSettings>> GetPagination(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<PaginationSettings>($"/indexes/{indexName}/settings/pagination", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdatePagination(HttpClient client, string indexName, PaginationSettings paginationSettings, CancellationToken token = default) =>
        client.PatchResponseAsync<MeilisearchTask, PaginationSettings>($"/indexes/{indexName}/settings/pagination", paginationSettings, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetPagination(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/pagination", token);


    //ProximityPrecision
    public static Task<HttpResponseWrapper<GetProximityPrecisionSettings>> GetProximityPrecision(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<GetProximityPrecisionSettings>($"/indexes/{indexName}/settings/proximity-precision", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateProximityPrecision(HttpClient client, string indexName, string proximityPrecision, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, string>($"/indexes/{indexName}/settings/proximity-precision", proximityPrecision, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetProximityPrecision(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/proximity-precision", token);


    //Ranking Rules
    public static Task<HttpResponseWrapper<List<string>>> GetRankingRules(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/ranking-rules", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateRankingRules(HttpClient client, string indexName, List<string> rankingRules, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/ranking-rules", rankingRules, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetRankingRules(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/ranking-rules", token);


    //Searchable Attributes
    public static Task<HttpResponseWrapper<List<string>>> GetSearchableAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/searchable-attributes", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSearchableAttributes(HttpClient client, string indexName, List<string> searchableAttributes, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/searchable-attributes", searchableAttributes, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSearchableAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/searchable-attributes", token);


    //Search Cutoff milliseconds
    public static Task<HttpResponseWrapper<int?>> GetSearchCutoffMilliseconds(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<int?>($"/indexes/{indexName}/settings/search-cutoff-ms", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSearchCutoffMilliseconds(HttpClient client, string indexName, int searchCutoffMilliseconds, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, int>($"/indexes/{indexName}/settings/search-cutoff-ms", searchCutoffMilliseconds, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSearchCutoffMilliseconds(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/search-cutoff-ms", token);


    //Separator Tokens
    public static Task<HttpResponseWrapper<List<string>>> GetSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/separator-tokens", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSeparatorTokens(HttpClient client, string indexName, List<string> separatorTokens, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/separator-tokens", separatorTokens, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/separator-tokens", token);


    //Non-Separator Tokens
    public static Task<HttpResponseWrapper<List<string>>> GetNonSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/non-separator-tokens", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateNonSeparatorTokens(HttpClient client, string indexName, List<string> nonSeparatorTokens, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/non-separator-tokens", nonSeparatorTokens, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetNonSeparatorTokens(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/non-separator-tokens", token);


    //Sortable Attributes
    public static Task<HttpResponseWrapper<List<string>>> GetSortableAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/sortable-attributes", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSortableAttributes(HttpClient client, string indexName, List<string> sortableAttributes, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/sortable-attributes", sortableAttributes, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSortableAttributes(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/sortable-attributes", token);


    //Stop Words
    public static Task<HttpResponseWrapper<List<string>>> GetStopWords(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<List<string>>($"/indexes/{indexName}/settings/stop-words", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateStopWords(HttpClient client, string indexName, List<string> stopWords, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, List<string>>($"/indexes/{indexName}/settings/stop-words", stopWords, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetStopWords(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/stop-words", token);


    //Synonyms
    public static Task<HttpResponseWrapper<Dictionary<string, List<string>>>> GetSynonyms(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<Dictionary<string, List<string>>>($"/indexes/{indexName}/settings/synonyms", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdateSynonyms(HttpClient client, string indexName, Dictionary<string, List<string>> synonyms, CancellationToken token = default) =>
        client.PutResponseAsync<MeilisearchTask, Dictionary<string, List<string>>>($"/indexes/{indexName}/settings/synonyms", synonyms, token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> ResetSynonyms(HttpClient client, string indexName, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexName}/settings/synonyms", token);


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