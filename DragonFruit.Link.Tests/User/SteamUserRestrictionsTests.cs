// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.User.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.User
{
    [TestClass]
    public class SteamUserRestrictionsTests : SteamApiTest
    {
        [TestMethod]
        public void TestUserRestrictions()
        {
            foreach (var user in Users)
            {
                var record = Client.GetUserRestrictions(user.Id);

                Assert.AreEqual(record.VacBanned, user.VACBanned);
                Assert.AreEqual(record.CommunityBanned, user.CommunityBanned);
                Assert.IsTrue(record.GameBans <= user.GameBanned);
            }
        }
    }
}