// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.User.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.User
{
    [TestClass]
    public class SteamUserBadgesTest : SteamApiTest
    {
        [TestMethod]
        public void TestSteamBadges()
        {
            foreach (var user in Users.Where(x => x.MinBadges > 0))
            {
                var badgeInfo = Client.GetUserBadges(user.Id);

                Assert.IsTrue(badgeInfo.CurrentLevel > user.MinLevel);
                Assert.IsTrue(badgeInfo.Badges.Count() > user.MinBadges);
            }
        }
    }
}
