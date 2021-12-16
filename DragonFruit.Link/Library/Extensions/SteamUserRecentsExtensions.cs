// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Library.Objects;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamUserRecentsExtensions
    {
        /// <summary>
        /// List the apps/games recently opened by the user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="maxEntries">The maximum number of items to return</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps recently used</returns>
        public static IEnumerable<SteamApp> GetUserRecentApps<T>(this T client, ulong steamId, ushort? maxEntries = null, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserRecentsRequest(steamId)
            {
                Limit = maxEntries
            };

            return client.Perform<SteamUserLibraryResponse>(request, token)?.Library.Apps;
        }

        /// <summary>
        /// List the apps/games recently opened by the user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="maxEntries">The maximum number of items to return</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps recently used</returns>
        public static async Task<IEnumerable<SteamApp>> GetUserRecentAppsAsync<T>(this T client, ulong steamId, ushort? maxEntries = null, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserRecentsRequest(steamId)
            {
                Limit = maxEntries
            };

            return (await client.PerformAsync<SteamUserLibraryResponse>(request, token).ConfigureAwait(false))?.Library.Apps;
        }
    }
}
