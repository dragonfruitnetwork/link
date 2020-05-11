// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.User.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.User
{
    [TestClass]
    public class SteamUserProfileTests : SteamApiTest
    {
        [TestMethod]
        public void TestUserProfileRequests()
        {
            foreach (var user in Users)
            {
                var idLookup = Client.GetUserProfile(user.Id);
                var urlLookup = Client.GetUserProfile(user.Url);

                Assert.AreEqual(idLookup.AccountCreatedEpoch, urlLookup.AccountCreatedEpoch);
                Assert.AreEqual(idLookup.Id, urlLookup.Id);
            }
        }
    }
}