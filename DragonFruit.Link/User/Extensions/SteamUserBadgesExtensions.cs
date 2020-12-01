// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserBadgesExtensions
    {
        /// <summary>
        /// Gets information about the user's badges and current level/xp
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>A <see cref="SteamUserBadgesInfo"/> item containing badges and level info</returns>
        public static SteamUserBadgesInfo GetUserBadges(this SteamApiClient client, ulong steamId)
        {
            var request = new SteamUserBadgesRequest(steamId);
            return client.Perform<SteamUserBadgesResponse>(request)?.BadgeInfo;
        }
    }
}
