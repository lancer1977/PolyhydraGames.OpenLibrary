namespace PolyhydraGames.OpenLibrary
{
    public static class Endpoint
    {
        //books/OL7353617M.json
        private static string _prefix = "https://openlibrary.org/";
        public static string Books() => $"{_prefix}books/";
        public static string Isbn() => $"{_prefix}isbn/";
        public static string SearchTitle() => $"{_prefix}search.json?title=";
        public static string Prefix() => _prefix;
        /*
         * http://openlibrary.org/search.json?q=the+lord+of+the+rings
http://openlibrary.org/search.json?title=the+lord+of+the+rings
http://openlibrary.org/search.json?author=tolkien
http://openlibrary.org/search.json?q=the+lord+of+the+rings&page=2
http://openlibrary.org/search/authors.json?q=twain
         */
    }
}