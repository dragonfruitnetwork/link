// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Store.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Store
{
    [TestClass]
    public class SteamFeaturedCategoriesListingTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamFeaturedCategoriesListingTest()
        {
            // ReSharper disable once IteratorMethodResultIsIgnored
            Client.GetFeaturedCategories();
        }
    }
}