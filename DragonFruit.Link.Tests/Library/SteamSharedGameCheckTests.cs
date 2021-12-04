// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Library.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Library
{
    [TestClass]
    public class SteamSharedGameCheckTests : SteamApiTest
    {
        [TestMethod]
        public void SharedGameCheckTest()
        {
            var result = Client.GetSharedGameOwner(SteamApps.RainbowSix, 76561198304799248);

            //0 = not shared
            Assert.IsTrue(result == 0);
        }
    }
}
