// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Requests;
using DragonFruit.Link.Servers.Responses;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerLoginResetExtensions
    {
        /// <summary>
        /// Reset a game servers' login token
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="serverId">The Steam Id of the game server</param>
        /// <returns>The new login token</returns>
        public static string ResetServerLoginToken(this SteamApiClient client, ulong serverId)
        {
            var request = new SteamGameServerLoginResetRequest(serverId);
            return client.Perform<SteamGameServerLoginResetResponse>(request)?.AccountInfo.ServerToken;
        }
    }
}
