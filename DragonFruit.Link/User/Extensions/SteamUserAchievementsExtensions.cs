// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.User.Objects;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserAchievementsExtensions
    {
        /// <summary>
        /// Get user's achievements for a specific game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get achievements for</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamUserAchievementObject"/>s</returns>
        public static IEnumerable<SteamUserAchievementObject> GetUserAchievements<T>(this T client, uint appId, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserAchievementsRequest(steamId, appId);
            return client.Perform<SteamUserAchievementsResponse>(request, token)?.Player.Achievements;
        }

        /// <summary>
        /// Get user's achievements for a specific game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get achievements for</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamUserAchievementObject"/>s</returns>
        public static async Task<IEnumerable<SteamUserAchievementObject>> GetUserAchievementsAsync<T>(this T client, uint appId, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserAchievementsRequest(steamId, appId);
            return (await client.PerformAsync<SteamUserAchievementsResponse>(request, token).ConfigureAwait(false))?.Player.Achievements;
        }
    }
}
