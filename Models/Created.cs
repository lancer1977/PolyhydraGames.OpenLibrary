using System;
using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    public class Created
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }
}