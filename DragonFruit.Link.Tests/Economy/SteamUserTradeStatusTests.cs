// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
