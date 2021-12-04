// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserGameStatsExtensions
    {
        /// <summary>
        /// Get user stats for a game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get stats for</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamUserGameStatsContainer"/>, containing stats and (sometimes) achievements</returns>
        public static SteamUserGameStatsContainer GetUserGameStats<T>(this T client, uint appId, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserGameStatsRequest(steamId, appId);
            return client.Perform<SteamUserGameStatsResponse>(request, token)?.Player;
        }

        /// <summary>
        /// Get user stats for a game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get stats for</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamUserGameStatsContainer"/>, containing stats and (sometimes) achievements</returns>
        public static async Task<SteamUserGameStatsContainer> GetUserGameStatsAsync<T>(this T client, uint appId, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserGameStatsRequest(steamId, appId);
            return (await client.PerformAsync<SteamUserGameStatsResponse>(request, token).ConfigureAwait(false))?.Player;
        }
    }
}
