 

using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Author : IKey
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}