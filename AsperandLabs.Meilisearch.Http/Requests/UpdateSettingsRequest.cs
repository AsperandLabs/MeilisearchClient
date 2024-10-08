using AsperandLabs.Meilisearch.Http.Constants;
using AsperandLabs.Meilisearch.Http.Shared;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class UpdateSettingsRequest: IndexSettings 
{
    public UpdateSettingsRequest()
    {
        Dictionary = [];
        DisplayedAttributes = Defaults.AllAttributes;
        DistinctAttribute = null;
        Faceting = FacetingSettings.Default;
        Pagination = PaginationSettings.Default;
        FilterableAttributes = [];
        ProximityPrecision = Defaults.ProximityPrecision;
        RankingRules = Defaults.RankingRules;
        SearchableAttributes = Defaults.AllAttributes;
        SearchCutOffMilliseconds = 1500;
        SeparatorTokens = [];
        NonSeparatorTokens = [];
        SortableAttributes = [];
        StopWords = [];
        Synonyms = new();
        TypoTolerance = TypoToleranceSettings.Default;
        Embedders = new Dictionary<string, EmbeddersSettings>();
    }
}