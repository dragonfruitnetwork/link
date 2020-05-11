// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Library.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Library
{
    [TestClass]
    public class SteamAppVersionCheckTests : SteamApiTest
    {
        [TestMethod]
        public void AppVersionCheckTest()
        {
            var invalidVersion = Client.CheckAppVersion(SteamApps.TeamFortress2, 1011);

            Assert.IsFalse(invalidVersion.IsLatestVersion);
            Assert.IsFalse(invalidVersion.VersionListed);
        }
    }
}