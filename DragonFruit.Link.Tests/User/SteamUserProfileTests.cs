// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
