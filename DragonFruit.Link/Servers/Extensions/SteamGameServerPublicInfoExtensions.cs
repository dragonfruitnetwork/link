// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
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
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The server's public facing information</returns>
        public static SteamGameServerPublicInfo GetServerInfo<T>(this T client, ulong serverId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerPublicInfoRequest(serverId);
            return client.Perform<SteamGameServerPublicInfoResponse>(request, token)?.PublicInfo;
        }

        /// <summary>
        /// Get publicly available info for a game server
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="serverId">The Steam Id of the server to get the info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The server's public facing information</returns>
        public static async Task<SteamGameServerPublicInfo> GetServerInfoAsync<T>(this T client, ulong serverId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerPublicInfoRequest(serverId);
            return (await client.PerformAsync<SteamGameServerPublicInfoResponse>(request, token).ConfigureAwait(false))?.PublicInfo;
        }
    }
}
