// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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