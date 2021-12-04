// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Linq;
using DragonFruit.Link.Game.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Game
{
    [TestClass]
    public class SteamGameSchemaTests : SteamApiTest
    {
        [TestMethod]
        public void GetSteamGameSchemaTest()
        {
            var schema = Client.GetSchemaForGame(SteamApps.CounterStrike);

            Assert.IsTrue(schema.Data.Stats.Count() > 225);
            Assert.IsTrue(schema.Data.Achievements.Count() > 150);
        }
    }
}
