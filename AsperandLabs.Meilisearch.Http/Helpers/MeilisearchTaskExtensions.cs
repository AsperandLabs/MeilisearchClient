using System.Text.Json;
using AsperandLabs.Meilisearch.Http.Clients;
using AsperandLabs.Meilisearch.Http.Enums;
using AsperandLabs.Meilisearch.Http.Responses;
using AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public static class MeilisearchTaskExtensions
{
    public static async Task<HttpResponseWrapper<MeilisearchTask>> WaitForCompletion(this MeilisearchTask task, HttpClient client, CancellationToken token = default)
    {
        while(true)
        {
            var updatedTask = await TasksClient.Get(client, task.Id, token);
            if (!updatedTask.WasSuccessful || updatedTask.Result == null)
                return updatedTask;

            if (updatedTask.Result.Status == MeilisearchTaskStatus.Succeeded ||
                updatedTask.Result.Status == MeilisearchTaskStatus.Failed ||
                updatedTask.Result.Status == MeilisearchTaskStatus.Canceled)
                return updatedTask;

            await Task.Delay(100, token);
        }
    }
    
    public static bool TryGetDocumentAdditionOrUpdateDetails(this MeilisearchTask task, out DocumentAdditionOrUpdate? details) =>
        TryGetDetails(task, MeilisearchTaskType.DocumentAdditionOrUpdate, out details);
    
    public static bool TryGetDocumentDeletionDetails(this MeilisearchTask task, out DocumentDeletion? details) =>
        TryGetDetails(task, MeilisearchTaskType.DocumentDeletion, out details);
    
    public static bool TryGetIndexCreationDetails(this MeilisearchTask task, out IndexCreation? details) =>
        TryGetDetails(task, MeilisearchTaskType.IndexCreation, out details);
    
    public static bool TryGetIndexUpdateDetails(this MeilisearchTask task, out IndexUpdate? details) =>
        TryGetDetails(task, MeilisearchTaskType.IndexUpdate, out details);
    
    public static bool TryGetIndexDeletionDetails(this MeilisearchTask task, out IndexDeletion? details) =>
        TryGetDetails(task, MeilisearchTaskType.IndexDeletion, out details);
    
    public static bool TryGetSettingsUpdateDetails(this MeilisearchTask task, out SettingsUpdate? details) =>
        TryGetDetails(task, MeilisearchTaskType.SettionsUpdate, out details);
    
    public static bool TryGetDumpCreationDetails(this MeilisearchTask task, out DumpCreation? details) =>
        TryGetDetails(task, MeilisearchTaskType.DumpCreation, out details);
    
    public static bool TryGetTaskCancelationDetails(this MeilisearchTask task, out TaskCancelation? details) =>
        TryGetDetails(task, MeilisearchTaskType.TaskCancelation, out details);
    
    public static bool TryGetTaskDeletionDetails(this MeilisearchTask task, out TaskDeletion? details) =>
        TryGetDetails(task, MeilisearchTaskType.TaskDeletion, out details);
    
    private static bool TryGetDetails<T>(MeilisearchTask task, MeilisearchTaskType targetTaskType, out T? details)
    {
        details = default;
        if (task.Type != targetTaskType || task.Details == null)
            return false;

        details = task.Details.Deserialize<T>();

        return details != null;
    }
}