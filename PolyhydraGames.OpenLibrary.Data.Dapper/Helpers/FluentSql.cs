namespace PolyhydraGames.VGCollect.Data.Dapper.Database
{
    public static class FluentSql
    {
        public static string SelectAll(string tableName) => $"SELECT * FROM {tableName}";
        public static string SelectName(string tableName) => $"SELECT Name FROM {tableName}";
        public static string OrderBy(this string sql) => sql + $" ORDER BY Name";
     
    }
}