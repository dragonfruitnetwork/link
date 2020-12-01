// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        /// <returns>A <see cref="SteamUserGameStatsContainer"/>, containing stats and (sometimes) achievements</returns>
        public static SteamUserGameStatsContainer GetUserGameStats(this SteamApiClient client, uint appId, ulong steamId)
        {
            var request = new SteamUserGameStatsRequest(steamId, appId);
            return client.Perform<SteamUserGameStatsResponse>(request)?.Player;
        }
    }
}
