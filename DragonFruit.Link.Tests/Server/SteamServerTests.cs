// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Linq;
using System.Threading;
using DragonFruit.Link.Servers.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragonFruit.Link.Tests.Server
{
    [TestClass]
    public class SteamServerTests : SteamApiTest
    {
        [TestMethod]
        public void ServerTest()
        {
            //because this creates items on an account, they also need to be removed so all the tests are condensed into a single test

            //vars for the session
            var appId = SteamApps.CounterStrike;
            var firstMemo = $"Test-{Guid.NewGuid().ToString().Split('-')[0]}";
            var secondMemo = $"Test-{Guid.NewGuid().ToString().Split('-')[0]}";

            Assert.AreNotEqual(firstMemo, secondMemo);

            //1. create a server
            var serverLoginInfo = Client.CreateGameServer(appId, firstMemo);
            Assert.IsFalse(string.IsNullOrWhiteSpace(serverLoginInfo.ServerToken));

            //2. check info
            var serverInfo = Client.GetGameServers().Servers!.Single(x => x.Id == serverLoginInfo.Id);

            Assert.AreEqual(appId, serverInfo.AppId);
            Assert.AreEqual(firstMemo, serverInfo.Memo);
            Assert.AreEqual(0UL, serverInfo.LastLogonEpoch);

            Assert.IsFalse(serverInfo.Expired);

            //3. change memo and verify
            Client.ChangeServerMemo(serverInfo.Id, secondMemo);
            Thread.Sleep(250);
            Assert.AreEqual(secondMemo, Client.GetGameServers().Servers!.Single(x => x.Id == serverLoginInfo.Id).Memo);

            //4. check login token query
            Assert.AreEqual(serverInfo.Id, Client.GetServerLoginTokenInfo(serverInfo.ServerToken).Id);

            //5. reset the token
            var newLogin = Client.ResetServerLoginToken(serverInfo.Id);
            Assert.AreNotEqual(serverInfo.ServerToken, newLogin);

            //6. get the public info
            Assert.AreEqual(appId, Client.GetServerInfo(serverInfo.Id).AppId);

            //7. delete server
            Client.DeleteGameServer(serverInfo.Id);
            Thread.Sleep(250);

            var newServers = Client.GetGameServers().Servers;
            if (newServers != null)
                Assert.ThrowsException<ArgumentNullException>(() => newServers.Single(x => x.Id == serverLoginInfo.Id));
        }
    }
}
