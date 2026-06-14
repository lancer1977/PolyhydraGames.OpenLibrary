using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using PolyhydraGames.Core.Interfaces;
using PolyhydraGames.VGCollect.Models;

namespace PolyhydraGames.VGCollect.Data.Dapper.Database
{
    public class PlatformDatabase : AbstractDapperDatabase<Platform> { public PlatformDatabase(IDBConnectionFactory connectionFactory) : base(connectionFactory) { } }
    public class CategoryDatabase : AbstractDapperDatabase<Category> { public CategoryDatabase(IDBConnectionFactory connectionFactory) : base(connectionFactory) { } }

    public class GameDatabase : AbstractDapperDatabase<Game>
    {
        public async Task<int> LastGameId()
        {
            using var cn = GetConnection(); 
            var result = await cn.QueryAsync<int>("SELECT Top 1 GameId FROM Game Order By GameId Desc");
            return result.First();
        }

        public async Task<bool> ContainsId(int gameId)
        {
            using (var cn = GetConnection())
            {
                var result = await cn.QueryAsync("SELECT Top 1 GameId FROM Game WHERE GameId = @gameId", new { gameId });
                var inGameLibrary = result.Any();
                if (inGameLibrary) return true;
            }


            return await SkipId(gameId);

        }


        public async Task<bool> SkipId(int gameId)
        {
            using var cn = GetConnection(); 
            var result = await cn.QueryAsync("SELECT Top 1 GameId FROM GameNull WHERE GameId = @gameId", new { gameId });
            return result.Any();
        }

        public async Task InsertSkip(int gameId)
        {
            using var cn = GetConnection();

            await cn.ExecuteAsync("insert into GameNull (GameId) values (@gameId)", new { gameId });

        }
        public GameDatabase(IDBConnectionFactory connectionFactory) : base(connectionFactory) { }
    }
}