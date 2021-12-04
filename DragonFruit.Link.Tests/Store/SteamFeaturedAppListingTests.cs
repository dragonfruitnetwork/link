// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Store.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Store
{
    [TestClass]
    public class SteamFeaturedAppListingTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamFeaturedAppListingTest()
        {
            Client.GetFeaturedAppListing();
        }
    }
}
