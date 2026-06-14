using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks; 
using PolyhydraGames.OpenLibrary.Models;

namespace PolyhydraGames.OpenLibrary
{
    public static class OpenLibraryApis
    {
        public static string Encode(this EncodingType type)
        {
            return "." + type.ToString().ToLower();
        } 
        ///books/OL25999571M
        public static async Task<SearchResponse> SearchBook(string value, EncodingType type = EncodingType.Json)
        {
           
            return await GetWebResponse<SearchResponse>(Endpoint.SearchTitle() + value.Replace(" ", "+"));
        }
        public static async Task<Book> GetBookByIsdn(string isdn, EncodingType type = EncodingType.Json)
        {

            return await GetWebResponse<Book>(Endpoint.Isbn() + isdn + type.Encode());
        }
        public static async Task<Book> GetBookByKey(string key, EncodingType type = EncodingType.Json)
        {

            return await GetWebResponse<Book>(Endpoint.Books() + key + type.Encode());
        }

        public static async Task<T> GetWebResponse<T>(string url)
        {
            try
            {
                Debug.WriteLine(url);
                var response = await Client.GetStringAsync(url);
                var t = response.FromJson<T>();
                return t;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return default(T);
            }
        }

        private static HttpClient _client;
        public static HttpClient Client => _client ?? (_client = new HttpClient());


    }
}
