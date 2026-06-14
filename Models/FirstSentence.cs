using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    public class FirstSentence
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}