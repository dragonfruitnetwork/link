// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Threading;
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
        public static IEnumerable<SteamUserAchievementObject> GetUserAchievements(this SteamApiClient client, uint appId, ulong steamId, CancellationToken token = default)
        {
            var request = new SteamUserAchievementsRequest(steamId, appId);
            return client.Perform<SteamUserAchievementsResponse>(request, token)?.Player.Achievements;
        }
    }
}