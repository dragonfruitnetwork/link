// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
