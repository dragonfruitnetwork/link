// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.User.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.User
{
    [TestClass]
    public class SteamUserLinkResolveTests : SteamApiTest
    {
        [TestMethod]
        public void TestVanityLinkResolve()
        {
            foreach (var user in Users.Where(x => !string.IsNullOrWhiteSpace(x.CustomUrlSegment)))
            {
                var resolvedId = Client.ResolveVanityUrl(user.CustomUrlSegment);

                Assert.AreEqual(resolvedId, user.Id);
            }
        }
    }
}
