using System.Collections.Generic;
using System.Threading.Tasks;
using PolyhydraGames.OpenLibrary.Models;

namespace PolyhydraGames.OpenLibrary
{
    public interface IOpenLibraryService
    {
        Task<Book> GetBookByIsbn(string isdn);
        Task<Book> GetBookByKey(string isdn);
        Task<IEnumerable<Doc>> Search(string value);

    }
}