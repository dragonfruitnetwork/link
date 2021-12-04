// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.User.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.User
{
    [TestClass]
    public class SteamUserGameStatsTests : SteamApiTest
    {
        [TestMethod]
        public void TestSteamGameStatsCounterStrike()
        {
            foreach (var user in Users.Where(x => x.MinKillsCounterStrike > 0))
            {
                var stats = Client.GetUserGameStats(SteamApps.CounterStrike, user.Id);

                Assert.IsTrue(stats.Stats.Single(x => x.Name == "total_kills").Value > user.MinKillsCounterStrike);
            }
        }

        [TestMethod]
        public void TestSteamGameStatsTeamFortress()
        {
            foreach (var user in Users.Where(x => x.MinKillsTeamFortress > 0))
            {
                var stats = Client.GetUserGameStats(SteamApps.TeamFortress2, user.Id);

                Assert.IsTrue(stats.Stats.Count() > 450);
                Assert.IsTrue(stats.Stats.Single(x => x.Name == "Scout.accum.iNumberOfKills").Value > user.MinKillsTeamFortress);
            }
        }
    }
}
