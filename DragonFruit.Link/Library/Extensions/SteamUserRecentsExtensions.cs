// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Library.Objects;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamUserRecentsExtensions
    {
        /// <summary>
        /// List all the apps/games recently opened by the user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps recently used</returns>
        public static IEnumerable<SteamApp> GetUserRecentApps(this SteamApiClient client, ulong steamId)
        {
            var request = new SteamUserRecentsRequest(steamId);
            return client.Perform<SteamUserLibraryResponse>(request).Library.Apps;
        }

        /// <summary>
        /// List the apps/games recently opened by the user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="maxEntries">The maximum number of items to return</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps recently used</returns>
        public static IEnumerable<SteamApp> GetUserRecentApps(this SteamApiClient client, ulong steamId, ushort maxEntries)
        {
            var request = new SteamUserRecentsRequest(steamId, maxEntries);
            return client.Perform<SteamUserLibraryResponse>(request).Library.Apps;
        }
    }
}
