// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Game.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Game
{
    [TestClass]
    public class SteamGameCurrentPlayersTests : SteamApiTest
    {
        [TestMethod]
        public void GetGameCurrentPlayersTest()
        {
            var currentCounterStrikePlayers = Client.GetNumberOfCurrentPlayers(SteamApps.CounterStrike);

            Assert.IsTrue(currentCounterStrikePlayers != 0);
        }
    }
}