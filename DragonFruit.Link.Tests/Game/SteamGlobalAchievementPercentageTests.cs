// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Linq;
using DragonFruit.Link.Game.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Game
{
    [TestClass]
    public class SteamGlobalAchievementPercentageTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamGlobalAchievementPercentageTest()
        {
            var achievementPercentages = Client.GetGlobalAchievementUnlockMetrics(SteamApps.CounterStrike);

            Assert.IsTrue(achievementPercentages.Count() > 150);
        }
    }
}