using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    public interface IKey
    {
        public string Key { get; set; }
    }
    public class Language: IKey
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}