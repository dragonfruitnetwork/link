// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Library.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Library
{
    [TestClass]
    public class SteamUserRecentsTests : SteamApiTest
    {
        [TestMethod]
        public void GetUserRecentsTest()
        {
            foreach (var user in Users)
            {
                Client.GetUserRecentApps(user.Id, 5);
            }
        }
    }
}
