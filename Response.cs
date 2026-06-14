using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary
{
    public class Response<T>
    {
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        [JsonPropertyName("results")]
        public T Result { get; set; }
    }
}