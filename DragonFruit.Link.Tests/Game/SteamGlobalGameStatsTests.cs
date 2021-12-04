// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.Game.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Game
{
    [TestClass]
    public class SteamGlobalGameStatsTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamGlobalGameStatsTest()
        {
            var metric = new[] { "global.map.emp_isle" };
            var stat = Client.GetGlobalGameStats(17740, metric);

            Assert.IsTrue(stat[metric.Single()] > 42510619710);
        }
    }
}
