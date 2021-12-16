// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Game.Objects;
using DragonFruit.Link.Game.Requests;
using DragonFruit.Link.Game.Responses;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGlobalAchievementPercentageExtensions
    {
        /// <summary>
        /// Get all the achievements for an app/game and their global unlock percentage
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get achievement metrics for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns><see cref="IEnumerable{T}"/> of <see cref="SteamAchievementUnlockMetric"/>s</returns>
        public static IEnumerable<SteamAchievementUnlockMetric> GetGlobalAchievementUnlockMetrics(this ApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamGlobalAchievementPercentageRequest(appId);
            return client.Perform<SteamGlobalAchievementPercentageResponse>(request, token)?.Global.Achievements;
        }

        /// <summary>
        /// Get all the achievements for an app/game and their global unlock percentage
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get achievement metrics for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns><see cref="IEnumerable{T}"/> of <see cref="SteamAchievementUnlockMetric"/>s</returns>
        public static async Task<IEnumerable<SteamAchievementUnlockMetric>> GetGlobalAchievementUnlockMetricsAsync(this ApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamGlobalAchievementPercentageRequest(appId);
            return (await client.PerformAsync<SteamGlobalAchievementPercentageResponse>(request, token).ConfigureAwait(false))?.Global.Achievements;
        }
    }
}
