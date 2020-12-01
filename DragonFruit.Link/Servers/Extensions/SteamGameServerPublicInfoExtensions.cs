// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Objects;
using DragonFruit.Link.Servers.Requests;
using DragonFruit.Link.Servers.Responses;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerPublicInfoExtensions
    {
        /// <summary>
        /// Get publicly available info for a game server
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="serverId">The Steam Id of the server to get the info for</param>
        /// <returns>The server's public facing information</returns>
        public static SteamGameServerPublicInfo GetServerInfo(this SteamApiClient client, ulong serverId)
        {
            var request = new SteamGameServerPublicInfoRequest(serverId);
            return client.Perform<SteamGameServerPublicInfoResponse>(request)?.PublicInfo;
        }
    }
}
