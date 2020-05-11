// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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