using System.Text.Json;

namespace PolyhydraGames.OpenLibrary;

public static class JsonExtensions
{
    public static T FromJson<T>(this string value)
    {
        return JsonSerializer.Deserialize<T>(value);
    }
}