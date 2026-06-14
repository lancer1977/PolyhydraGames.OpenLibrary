using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PolyhydraGames.OpenLibrary.Models;

namespace PolyhydraGames.OpenLibrary
{
    public class OpenLibraryService : IOpenLibraryService
    {
        public  async Task<Book> GetBook(string isdn)
        {
            try
            {
                var result = await OpenLibraryApis.GetBookByIsdn(isdn);
                return await OpenLibraryApis.GetBookByKey(result.Key);
            }
            catch (Exception ex)
            {
                return null;
            }
  
        }

        public Task<Book> GetBookByIsbn(string isdn)
        {
            return OpenLibraryApis.GetBookByIsdn(isdn);
        }

        public Task<Book> GetBookByKey(string key)
        {
            return   OpenLibraryApis.GetBookByKey(key);
        }

        /// <summary>
        /// Returns the OpenLibrary Keys found
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Doc>> Search(string value)
        {
            var response = new List<Doc>();
            var results = await OpenLibraryApis.SearchBook(value);
            if (results?.Docs == null) return response;
            return results.Docs;
        }

 
    }
}