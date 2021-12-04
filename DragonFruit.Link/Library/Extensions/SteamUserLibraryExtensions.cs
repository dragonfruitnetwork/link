// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Library.Objects;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamUserLibraryExtensions
    {
        /// <summary>
        /// List all the apps owned by the user, optionally including free-to-play games
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="includeFreeGames">Whether to include free-to-play games (defaults to false)</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps owned by the user</returns>
        public static IEnumerable<SteamApp> GetUserAppLibrary<T>(this T client, ulong steamId, bool includeFreeGames = false, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserLibraryRequest(steamId, includeFreeGames);
            return client.Perform<SteamUserLibraryResponse>(request, token)?.Library.Apps;
        }

        /// <summary>
        /// List all the apps owned by the user, optionally including free-to-play games
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="includeFreeGames">Whether to include free-to-play games (defaults to false)</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps owned by the user</returns>
        public static async Task<IEnumerable<SteamApp>> GetUserAppLibraryAsync<T>(this T client, ulong steamId, bool includeFreeGames = false, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserLibraryRequest(steamId, includeFreeGames);
            return (await client.PerformAsync<SteamUserLibraryResponse>(request, token).ConfigureAwait(false))?.Library.Apps;
        }
    }
}
