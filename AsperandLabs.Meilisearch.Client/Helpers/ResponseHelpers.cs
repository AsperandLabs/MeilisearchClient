using AsperandLabs.Meilisearch.Http.Helpers;

namespace AsperandLabs.Meilisearch.Client.Helpers;

public static class ResponseHelpers
{
    public static T UnwrapValue<T>(this HttpResponseWrapper<T> response)
    {
        ExceptionHelpers.ThrowHttpResponseExceptionIfError(response);
        
        if(response.Result == null)
            ExceptionHelpers.ThrowGenericException();
        
        return response.Result!;
    }
}