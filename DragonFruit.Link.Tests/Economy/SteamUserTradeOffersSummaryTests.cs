// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Economy
{
    [TestClass]
    public class SteamUserTradeOffersSummaryTests : SteamApiTest
    {
        [TestMethod]
        public void UserTradeOffersSummaryTest()
        {
            Client.GetTradeOffersSummary();
        }
    }
}
