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
    public static class SteamUserGameServerListingExtensions
    {
        /// <summary>
        /// Get the API key owner's steam game servers
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The API key owner's account standing and any server they have registered, for all games</returns>
        public static SteamUserGameServerListing GetGameServers<T>(this T client, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserGameServerListingRequest();
            return client.Perform<SteamUserGameServerListingResponse>(request, token)?.ServerListing;
        }

        /// <summary>
        /// Get the API key owner's steam game servers
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The API key owner's account standing and any server they have registered, for all games</returns>
        public static async Task<SteamUserGameServerListing> GetGameServersAsync<T>(this T client, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserGameServerListingRequest();
            return (await client.PerformAsync<SteamUserGameServerListingResponse>(request, token).ConfigureAwait(false))?.ServerListing;
        }
    }
}
