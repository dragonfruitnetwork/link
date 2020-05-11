﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Linq;
using DragonFruit.Link.Library.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Library
{
    [TestClass]
    public class SteamStoreListingTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamStoreListingTest()
        {
            var partOne = Client.GetStoreApps();
            var partTwo = Client.GetStoreApps(partOne);

            //check there are 10000 items in each
            Assert.AreEqual(partOne.Apps.Count(), 10000);
            Assert.AreEqual(partTwo.Apps.Count(), 10000);

            //check that ALL the item ids are different
            Assert.AreEqual(partOne.Apps.Concat(partTwo.Apps).Select(x => x.Id).Distinct().Count(), 20000);
        }
    }
}