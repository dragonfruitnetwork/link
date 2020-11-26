// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Game.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DragonFruit.Link.Tests.Game
{
    [TestClass]
    public class SteamGlobalGameStatsTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamGlobalGameStatsTest()
        {
            var metric = new List<string> { "global.map.emp_isle" };
            var stat = Client.GetGlobalGameStats(17740, metric);

            Assert.IsTrue(stat[metric.Single()] > 42510619710);
        }
    }
}