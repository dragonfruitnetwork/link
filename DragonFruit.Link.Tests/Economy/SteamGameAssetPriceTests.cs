// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.Economy.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Economy
{
    [TestClass]
    public class SteamGameAssetPriceTests : SteamApiTest
    {
        [TestMethod]
        public void GameAssetPriceTest()
        {
            var items = Client.GetMarketPricesForApp(SteamApps.CounterStrike);

            foreach (var item in items)
            {
                _ = item.Prices.Single(x => x.Key == "USD").Value;
                _ = item.Prices.Single(x => x.Key == "GBP").Value;
                _ = item.Prices.Single(x => x.Key == "EUR").Value;
            }
        }
    }
}
