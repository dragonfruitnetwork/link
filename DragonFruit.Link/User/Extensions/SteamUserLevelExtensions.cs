// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserLevelExtensions
    {
        /// <summary>
        /// Get a User's Steam Level
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An unsigned int32 representing the user's level</returns>
        public static uint? GetUserLevel<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserLevelRequest(steamId);
            return client.Perform<SteamUserLevelResponse>(request, token)?.UserLevelInfo.Level;
        }

        /// <summary>
        /// Get a User's Steam Level
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An unsigned int32 representing the user's level</returns>
        public static async Task<uint?> GetUserLevelAsync<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserLevelRequest(steamId);
            return (await client.PerformAsync<SteamUserLevelResponse>(request, token).ConfigureAwait(false))?.UserLevelInfo.Level;
        }
    }
}
