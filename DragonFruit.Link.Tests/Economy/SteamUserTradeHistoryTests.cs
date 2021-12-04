// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.Economy.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Economy
{
    [TestClass]
    public class SteamUserTradeHistoryTests : SteamApiTest
    {
        [TestMethod]
        public void UserTradeHistoryTest()
        {
            var response = Client.GetTradeHistory(50);

            Assert.IsTrue(response.More.Value);
            Assert.AreEqual(response.Trades.Count(), 50);
        }
    }
}
