// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Threading;
using DragonFruit.Link.Library.Objects;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamUserLibraryExtensions
    {
        /// <summary>
        /// List all the paid apps owned by the user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps owned by the user</returns>
        public static IEnumerable<SteamApp> GetUserAppLibrary(this SteamApiClient client, ulong steamId)
        {
            return GetUserAppLibrary(client, steamId, false);
        }

        /// <summary>
        /// List all the apps owned by the user, optionally including free-to-play games
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamApp"/>s, representing the games/apps owned by the user</returns>
        public static IEnumerable<SteamApp> GetUserAppLibrary(this SteamApiClient client, ulong steamId, bool includeFreeGames, CancellationToken token = default)
        {
            var request = new SteamUserLibraryRequest(steamId, includeFreeGames);
            return client.Perform<SteamUserLibraryResponse>(request, token)?.Library.Apps;
        }
    }
}