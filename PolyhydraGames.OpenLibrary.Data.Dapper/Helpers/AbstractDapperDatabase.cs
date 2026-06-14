using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using PolyhydraGames.Core.Interfaces;

namespace PolyhydraGames.VGCollect.Data.Dapper.Database
{
    public class AbstractDapperDatabase<TImplementation>  where TImplementation : class
    {

        public AbstractDapperDatabase(IDBConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            TableName = typeof(TImplementation).Name;
        }
         
        public Type GetImplementationType() => typeof(TImplementation);
        private readonly IDBConnectionFactory _connectionFactory;
        protected string TableName { get; }
        protected string BaseSql => $"SELECT * FROM {TableName}  ";
        protected virtual string SqlFromId => $"SELECT * FROM {TableName} WHERE Id = @Id;";
        protected virtual string SqlFromName => $"SELECT * FROM {TableName} WHERE Name = @Name;";
        protected virtual string SqlMatching => $"SELECT * FROM {TableName} WHERE Name like @Name;";
        protected virtual string SqlNames => $"SELECT Name FROM {TableName};";



        public void Insert(TImplementation item)
        {
            using var cn = GetConnection();
            cn.Insert(item);
        }

        public async Task InsertAsync(TImplementation item)
        {
            using var cn = GetConnection();
            await cn.InsertAsync(item);
        }

        public void Insert(IEnumerable<TImplementation> items)
        {
            using var cn = GetConnection();
            cn.Insert(items);
        }

        protected IDbConnection GetConnection()
        {
            return _connectionFactory.GetConnection();
        }

        public void Initialize(IDataSource<TImplementation> data)
        {
            if (Items.Any()) return;
            var items = data.Items().Cast<TImplementation>();
            Insert(items);
        }

        public void Initialize()
        {
        }

        public IEnumerable<TImplementation> Where(string sql, bool order = false)
        {
            using var cn = GetConnection();
            return cn.Query<TImplementation>(BaseSql + " " + sql + (order ? " ORDER BY Name" : ""));
        }

        public TImplementation Item(int id)
        {
            using var cn = GetConnection();
            return cn.QueryFirst<TImplementation>(SqlFromId, new { Id = id });
        }

        public IEnumerable<TImplementation> Query(string sql)
        {
            using var cn = GetConnection();
            var query = BaseSql + " " + sql;
            return cn.Query<TImplementation>(query);
        }

        public TImplementation QueryFirst(string sql)
        {
            using var cn = GetConnection();
            return cn.QueryFirst<TImplementation>(BaseSql + " " + sql);
        }

        public IEnumerable<TImplementation> Items
        {
            get
            {
                using var cn = GetConnection();
                return cn.Query<TImplementation>(BaseSql);
            }
        }



        public TImplementation Item(string name)
        {
            using var cn = GetConnection();
            return cn.QueryFirstOrDefault<TImplementation>(SqlFromName, new { Name = name });
        }



        public IEnumerable<string> Names()
        {
            using var cn = GetConnection();
            return cn.Query<string>(SqlNames);
        }

        public IEnumerable<TImplementation> Matching(string name = "")
        {
            using var cn = GetConnection();
            return cn.Query<TImplementation>(SqlMatching, new { Name = "%" + name + "%" });
        }
        public IEnumerable<TImplementation> Contains(string name = "")
        {
            using var cn = GetConnection();
            return cn.Query<TImplementation>(SqlMatching, new { Name = "%" + name + "%" });
        }

        public IEnumerable<TImplementation> RunQuery(string sql, params object[] objectList)
        {
            using var cn = GetConnection();
            return cn.Query<TImplementation>(sql, objectList);
        }

    }
}