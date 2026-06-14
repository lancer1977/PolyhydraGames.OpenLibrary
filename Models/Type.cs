using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    public class Type
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}