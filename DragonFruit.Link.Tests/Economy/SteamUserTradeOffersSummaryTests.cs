// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
