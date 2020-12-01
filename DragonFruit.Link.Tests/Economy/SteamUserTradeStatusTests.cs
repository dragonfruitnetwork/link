// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Linq;
using DragonFruit.Link.Economy.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Economy
{
    [TestClass]
    public class SteamUserTradeStatusTests : SteamApiTest
    {
        [TestMethod]
        public void UserTradeHistoryTest()
        {
            var response = Client.GetTradeStatus(2117134991960769090).Trades.Single();

            Assert.IsTrue(response.Status == 3);
            Assert.AreEqual(response.TradeStartedEpoch, 1527625970L);
        }
    }
}
