using System.Net.Http.Headers;

namespace AsperandLabs.Meilisearch.Http.Tests;

public static class HttpClients
{
    public static HttpClient ValidLocalHttpClient()
    {
        var client = new HttpClient();

        client.BaseAddress = new("http://localhost:7700");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "HTHcCpWQZbDNlk3WpmEmyEAzbG3RQpbOTsE9fUOxy5o");
        
        return client;
    }
    
    
    public static HttpClient UnauthorizedLocalHttpClient()
    {
        var client = new HttpClient();

        client.BaseAddress = new("http://localhost:7700");
        
        return client;
    }
}