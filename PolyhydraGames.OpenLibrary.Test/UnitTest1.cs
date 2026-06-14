using NUnit;
using NUnit.Framework;
using PolyhydraGames.OpenLibrary;

namespace PolyhydraGames.OpenLibrary.Test
{
    public class Tests
    {
        [Test]
        public void Endpoint_Surfaces_OpenLibraryRoots()
        {
            Assert.That(Endpoint.Prefix(), Is.EqualTo("https://openlibrary.org/"));
            Assert.That(Endpoint.Books(), Is.EqualTo("https://openlibrary.org/books/"));
            Assert.That(Endpoint.Isbn(), Is.EqualTo("https://openlibrary.org/isbn/"));
        }

        [Test]
        public void EncodingType_MapsToExpectedSuffix()
        {
            Assert.That(EncodingType.Json.Encode(), Is.EqualTo(".json"));
            Assert.That(EncodingType.Xml.Encode(), Is.EqualTo(".xml"));
        }
    }
}
