// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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

            Assert.IsTrue(response.More!.Value);
            Assert.AreEqual(response.Trades.Count(), 50);
        }
    }
}
