using System.Diagnostics;
using NUnit;
using System.Threading.Tasks;
using NUnit.Framework;
using PolyhydraGames.Core.Global.Helpers;

namespace PolyhydraGames.OpenLibrary.Test
{
    public class Tests
    {
        [Test]
        public async Task GetData()
        {
            //var file = PolyhydraGames
            var result = await WebHelpers.GetString("https://rpggeek.com/rpgitemversion/1000/");
            result = result.Replace("\t", "").Replace("\n", "");
            Assert.IsTrue(result.Contains("2002"));
        }
    }
}