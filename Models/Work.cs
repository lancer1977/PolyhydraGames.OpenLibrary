using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    public class Work : IKey
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}