// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
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
        public static SteamUserBadgesInfo GetUserBadges<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserBadgesRequest(steamId);
            return client.Perform<SteamUserBadgesResponse>(request, token)?.BadgeInfo;
        }

        /// <summary>
        /// Gets information about the user's badges and current level/xp
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>A <see cref="SteamUserBadgesInfo"/> item containing badges and level info</returns>
        public static async Task<SteamUserBadgesInfo> GetUserBadgesAsync<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserBadgesRequest(steamId);
            return (await client.PerformAsync<SteamUserBadgesResponse>(request, token).ConfigureAwait(false))?.BadgeInfo;
        }
    }
}
