using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PolyhydraGames.OpenLibrary.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Doc
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("seed")]
        public List<string> Seed { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("title_suggest")]
        public string TitleSuggest { get; set; }

        [JsonPropertyName("has_fulltext")]
        public bool HasFulltext { get; set; }

        [JsonPropertyName("edition_count")]
        public int EditionCount { get; set; }

        [JsonPropertyName("edition_key")]
        public List<string> EditionKey { get; set; }

        [JsonPropertyName("publish_date")]
        public List<string> PublishDate { get; set; }

        [JsonPropertyName("publish_year")]
        public List<int> PublishYear { get; set; }

        [JsonPropertyName("first_publish_year")]
        public int FirstPublishYear { get; set; }

        [JsonPropertyName("number_of_pages_median")]
        public int NumberOfPagesMedian { get; set; }

        [JsonPropertyName("lccn")]
        public List<string> Lccn { get; set; }

        [JsonPropertyName("publish_place")]
        public List<string> PublishPlace { get; set; }

        [JsonPropertyName("oclc")]
        public List<string> Oclc { get; set; }

        [JsonPropertyName("contributor")]
        public List<string> Contributor { get; set; }

        [JsonPropertyName("lcc")]
        public List<string> Lcc { get; set; }

        [JsonPropertyName("ddc")]
        public List<string> Ddc { get; set; }

        [JsonPropertyName("isbn")]
        public List<string> Isbn { get; set; }

        [JsonPropertyName("last_modified_i")]
        public int LastModifiedI { get; set; }

        [JsonPropertyName("ebook_count_i")]
        public int EbookCountI { get; set; }

        [JsonPropertyName("ia")]
        public List<string> Ia { get; set; }

        [JsonPropertyName("public_scan_b")]
        public bool PublicScanB { get; set; }

        [JsonPropertyName("ia_collection_s")]
        public string IaCollectionS { get; set; }

        [JsonPropertyName("lending_edition_s")]
        public string LendingEditionS { get; set; }

        [JsonPropertyName("lending_identifier_s")]
        public string LendingIdentifierS { get; set; }

        [JsonPropertyName("printdisabled_s")]
        public string PrintdisabledS { get; set; }

        [JsonPropertyName("cover_edition_key")]
        public string CoverEditionKey { get; set; }

        [JsonPropertyName("cover_i")]
        public int CoverI { get; set; }

        [JsonPropertyName("publisher")]
        public List<string> Publisher { get; set; }

        [JsonPropertyName("language")]
        public List<string> Language { get; set; }

        [JsonPropertyName("author_key")]
        public List<string> AuthorKey { get; set; }

        [JsonPropertyName("author_name")]
        public List<string> AuthorName { get; set; }

        [JsonPropertyName("author_alternative_name")]
        public List<string> AuthorAlternativeName { get; set; }

        [JsonPropertyName("person")]
        public List<string> Person { get; set; }

        [JsonPropertyName("place")]
        public List<string> Place { get; set; }

        [JsonPropertyName("subject")]
        public List<string> Subject { get; set; }

        [JsonPropertyName("time")]
        public List<string> Time { get; set; }

        [JsonPropertyName("id_alibris_id")]
        public List<string> IdAlibrisId { get; set; }

        [JsonPropertyName("id_amazon")]
        public List<string> IdAmazon { get; set; }

        [JsonPropertyName("id_canadian_national_library_archive")]
        public List<string> IdCanadianNationalLibraryArchive { get; set; }

        [JsonPropertyName("id_depósito_legal")]
        public List<string> IdDepósitoLegal { get; set; }

        [JsonPropertyName("id_goodreads")]
        public List<string> IdGoodreads { get; set; }

        [JsonPropertyName("id_google")]
        public List<string> IdGoogle { get; set; }

        [JsonPropertyName("id_librarything")]
        public List<string> IdLibrarything { get; set; }

        [JsonPropertyName("id_overdrive")]
        public List<string> IdOverdrive { get; set; }

        [JsonPropertyName("id_paperback_swap")]
        public List<string> IdPaperbackSwap { get; set; }

        [JsonPropertyName("id_wikidata")]
        public List<string> IdWikidata { get; set; }

        [JsonPropertyName("ia_loaded_id")]
        public List<string> IaLoadedId { get; set; }

        [JsonPropertyName("ia_box_id")]
        public List<string> IaBoxId { get; set; }

        [JsonPropertyName("publisher_facet")]
        public List<string> PublisherFacet { get; set; }

        [JsonPropertyName("person_key")]
        public List<string> PersonKey { get; set; }

        [JsonPropertyName("place_key")]
        public List<string> PlaceKey { get; set; }

        [JsonPropertyName("time_facet")]
        public List<string> TimeFacet { get; set; }

        [JsonPropertyName("person_facet")]
        public List<string> PersonFacet { get; set; }

        [JsonPropertyName("subject_facet")]
        public List<string> SubjectFacet { get; set; }

        [JsonPropertyName("_version_")]
        public object Version { get; set; }

        [JsonPropertyName("place_facet")]
        public List<string> PlaceFacet { get; set; }

        [JsonPropertyName("lcc_sort")]
        public string LccSort { get; set; }

        [JsonPropertyName("author_facet")]
        public List<string> AuthorFacet { get; set; }

        [JsonPropertyName("subject_key")]
        public List<string> SubjectKey { get; set; }

        [JsonPropertyName("ddc_sort")]
        public string DdcSort { get; set; }

        [JsonPropertyName("time_key")]
        public List<string> TimeKey { get; set; }

        [JsonPropertyName("first_sentence")]
        public List<string> FirstSentence { get; set; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; set; }

        [JsonPropertyName("id_bcid")]
        public List<string> IdBcid { get; set; }
    }

    public class SearchResponse
    {
        [JsonPropertyName("numFound")]
        public int NumFound { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("numFoundExact")]
        public bool NumFoundExact { get; set; }

        [JsonPropertyName("docs")]
        public List<Doc> Docs { get; set; }

        [JsonPropertyName("num_found")]
        public int Num_Found { get; set; }

        [JsonPropertyName("q")]
        public string Q { get; set; }

        [JsonPropertyName("offset")]
        public object Offset { get; set; }
    }
 
}