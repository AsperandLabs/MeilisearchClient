using System.Reflection;
using AsperandLabs.Meilisearch.Client.Attributes;

namespace AsperandLabs.Meilisearch.Client.Helpers;

public static class ReflectionHelpers
{
    public static string GetIdName<T>()
    {
        var type = typeof(T);
        PropertyInfo? idProperty = type.GetProperty("Id");
        List<PropertyInfo> idAttributeProperties = [];
        foreach(var property in type.GetProperties())
        {
            var temp = property.GetCustomAttribute<IdAttribute>();
            if(temp == null)
                continue;
            idAttributeProperties.Add(property);
        }
        
        if(idAttributeProperties.Count == 1)
            return idAttributeProperties[0].Name;
        
        if(idAttributeProperties.Count > 1)
            throw new MeilisearchException($"More than one Id candidates found on type {nameof(T)}: {string.Join(", ", idAttributeProperties.Select(x => x.Name))}");
        
        if(idProperty != null)
            return idProperty.Name;
        
        throw new MeilisearchException($"No Id candidates found on type {typeof(T)}, please use the Id attribute or name a property 'Id'");
    }
}