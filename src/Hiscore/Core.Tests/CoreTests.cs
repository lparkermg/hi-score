using NUnit.Framework;
using LPSoft.Hiscore.Core;
using System.Threading.Tasks;

namespace LPSoft.Hiscore.Core.Tests
{
    public class CoreTests
    {
        private IScorerService _scoringService;

        [SetUp]
        public void Setup()
        {
            _scoringService = new SqlScoringService();
        }

        [Test]
        public async Task With_No_Items_Scorer_Service_Should_Return_No_Items()
        {
            var results = await _scoringService.GetAsync();
            Assert.AreEqual(0, results.Count);
        }
    }
}