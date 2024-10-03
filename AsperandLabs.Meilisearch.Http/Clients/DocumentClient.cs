using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class DocumentClient
{
    
    public static Task<HttpResponseWrapper<GetDocumentsResponse<T>>> Get<T>(HttpClient client, string indexName, GetDocumentsRequest request, CancellationToken token = default)
    {
        var response = client.PostAsJsonAsync($"/indexes/{indexName}/documents/fetch", request, token);
        return HttpResponseWrapper<GetDocumentsResponse<T>>.FromResponse(response, token);
    }
    
    
    public static Task<HttpResponseWrapper<GetDocumentsResponse<T>>> Get<T>(HttpClient client, string indexName, string documentId, List<string> fields, bool retrieveVectors, CancellationToken token = default)
    {
        var queryString = QueryStringHelpers.Create(new Dictionary<string, object?>
        {
            ["fields"] = string.Join(",", fields),
            ["retrieveVectors"] = retrieveVectors
        });
        
        var response = client.GetAsync($"/indexes/{indexName}/documents/{documentId}{queryString}", token);
        return HttpResponseWrapper<GetDocumentsResponse<T>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<GetDocumentsResponse<T>>> AddOrReplace<T>(HttpClient client, string indexName, List<T> documents, CancellationToken token = default)
    {
        var response = client.PostAsJsonAsync($"/indexes/{indexName}/documents", documents, token);
        return HttpResponseWrapper<GetDocumentsResponse<T>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<GetDocumentsResponse<T>>> AddOrUpdate<T>(HttpClient client, string indexName, List<T> documents, CancellationToken token = default)
    {
        var response = client.PutAsJsonAsync($"/indexes/{indexName}/documents", documents, token);
        return HttpResponseWrapper<GetDocumentsResponse<T>>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> DeleteAll(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/documents", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Delete(HttpClient client, string indexName, string documentId, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/documents/{documentId}", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Delete(HttpClient client, string indexName, List<string> documentIds, CancellationToken token = default)
    {
        var response = client.PostAsJsonAsync($"/indexes/{indexName}/documents/delete-batch", documentIds, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> DeleteBy(HttpClient client, string indexName, string filter, CancellationToken token = default)
    {
        var response = client.PostAsJsonAsync($"/indexes/{indexName}/documents/delete", new { filter }, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    //todo: Update documents with function is Experimental
}