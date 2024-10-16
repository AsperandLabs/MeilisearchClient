using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Client;

public class IndexClient<T>
{
    private readonly HttpClient _client;
    private readonly MeilisearchIndex _index;

    public string Name => _index.Id;

    public IndexClient(HttpClient client, MeilisearchIndex index)
    {
        _client = client;
        _index = index;
    }
}