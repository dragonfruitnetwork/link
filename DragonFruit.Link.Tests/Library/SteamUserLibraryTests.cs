// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.Library.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Library
{
    [TestClass]
    public class SteamUserLibraryTests : SteamApiTest
    {
        [TestMethod]
        public void GetUserLibraryTest()
        {
            foreach (var user in Users)
            {
                var lib = Client.GetUserAppLibrary(user.Id, true);

                Assert.IsTrue(lib.Count() >= user.MinGames);
            }
        }
    }
}
