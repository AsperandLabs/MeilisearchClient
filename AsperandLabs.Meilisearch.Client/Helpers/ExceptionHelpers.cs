using AsperandLabs.Meilisearch.Http.Helpers;

namespace AsperandLabs.Meilisearch.Client;

public class ExceptionHelpers
{
    public static void ThrowHttpResponseExceptionIfError<T>(HttpResponseWrapper<T> response)
    {
        if (response.WasSuccessful)
            return;
        
        if(response.Error == null)
            throw new MeilisearchException("An error occured while processing the request.");
        throw new MeilisearchException($"{response.Error.Code}: {response.Error.Message}. See {response.Error.Link} for more details");
    }
    
    
    public static void ThrowGenericException()
    {
        throw new MeilisearchException("An error occured while processing the request.");
    }
    
    public static void ThrowException(string message)
    {
        throw new MeilisearchException(message);
    }
}