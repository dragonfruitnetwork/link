﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Net.Http;
using DragonFruit.Link.Servers.Requests;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerMemoChangeExtensions
    {
        /// <summary>
        /// Change a server's memo/side-note
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="serverId">The Steam Id of the game server</param>
        /// <param name="newMemo">The new memo to set</param>
        public static void ChangeServerMemo(this SteamApiClient client, ulong serverId, string newMemo)
        {
            HttpResponseMessage response = null;

            try
            {
                var request = new SteamGameServerMemoChangeRequest(serverId, newMemo);
                response = client.Perform(request);
            }
            finally
            {
                response?.Dispose();
            }
        }
    }
}
