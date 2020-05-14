// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Linq;
using DragonFruit.Link.Economy.Extensions;
using DragonFruit.Link.Economy.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Economy
{
    [TestClass]
    public class SteamGameAssetInfoTests : SteamApiTest
    {
        private readonly IDictionary<ulong, string> _testItems = new Dictionary<ulong, string>
        {
            [3761545710] = "Prisma 2 Case Key"
        };

        [TestMethod]
        public void GameAssetInfoTest()
        {
            var items = Client.GetMarketItemsForApp(SteamApps.CounterStrike, _testItems.Keys);

            foreach (var item in _testItems)
            {
                CheckItem(items, item.Key, item.Value);
            }
        }

        private void CheckItem(IEnumerable<SteamGameEconomyAsset> assets, ulong item, string name)
        {
            Assert.AreEqual(assets.SingleOrDefault(x => x.ClassId == item)?.Name, name);
        }
    }
}
