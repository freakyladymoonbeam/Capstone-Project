using System.Text.Json;

namespace IoTPlatform.Infrastructure.SeedData;

/// <summary>
/// Provides helper methods for loading seed data from JSON files.
/// </summary>
public static class JsonSeedLoader
{
    /// <summary>
    /// Loads seed data from a JSON file and deserializes it into the specified type.
    /// </summary>
    /// <typeparam name="T">The type of the seed data to load.</typeparam>
    /// <param name="filePath">The path to the JSON file containing the seed data.</param>
    /// <returns>The deserialized seed data if the file exists; otherwise, null.</returns>
    public static async Task<T?> LoadAsync<T>(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return default;
        }

        var json = await File.ReadAllTextAsync(filePath);

        return JsonSerializer.Deserialize<T>(json);
    }
}