// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Linq;
using DragonFruit.Link.Store.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Store
{
    [TestClass]
    public class SteamStoreAppListingTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamStoreAppListingTest()
        {
            CheckPublisher(216938, null);
            CheckPublisher(SteamApps.RainbowSix, "Ubisoft");
            CheckPublisher(SteamApps.CounterStrike, "Valve");
            CheckPublisher(SteamApps.TeamFortress2, "Valve");
        }

        private void CheckPublisher(uint appId, string publisher)
        {
            var listing = Client.GetStoreListing(appId);
            Assert.IsTrue(listing.Publishers.Contains(publisher));
        }
    }
}