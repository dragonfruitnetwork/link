// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
