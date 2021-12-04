// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Servers.Objects;
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
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The <see cref="SteamGameServerAccountInfo"/> with the new login token</returns>
        public static SteamGameServerAccountInfo ResetServerLoginToken<T>(this T client, ulong serverId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerLoginResetRequest(serverId);
            return client.Perform<SteamGameServerLoginResetResponse>(request, token)?.AccountInfo;
        }

        /// <summary>
        /// Reset a game servers' login token
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="serverId">The Steam Id of the game server</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The <see cref="SteamGameServerAccountInfo"/> with the new login token</returns>
        public static async Task<SteamGameServerAccountInfo> ResetServerLoginTokenAsync<T>(this T client, ulong serverId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerLoginResetRequest(serverId);
            return (await client.PerformAsync<SteamGameServerLoginResetResponse>(request, token).ConfigureAwait(false))?.AccountInfo;
        }
    }
}
