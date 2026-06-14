using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{
    public class Identifiers
    {
        [JsonPropertyName("goodreads")]
        public List<string> Goodreads { get; set; }

        [JsonPropertyName("librarything")]
        public List<string> Librarything { get; set; }
    }
}