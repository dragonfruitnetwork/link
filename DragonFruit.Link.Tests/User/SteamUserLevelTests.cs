// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.User.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.User
{
    [TestClass]
    public class SteamUserLevelTests : SteamApiTest
    {
        [TestMethod]
        public void TestSteamUserLevel()
        {
            foreach (var user in Users)
            {
                var userLevel = Client.GetUserLevel(user.Id);
                Assert.IsTrue(userLevel >= user.MinLevel);
            }
        }
    }
}
