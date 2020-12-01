// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Linq;
using DragonFruit.Link.User.Objects;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserRestrictionsExtensions
    {
        /// <summary>
        /// Check the user's behaviour record for bans
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>A <see cref="SteamUserRestriction"/> object containing the user's record</returns>
        public static SteamUserRestriction GetUserRestrictions(this SteamApiClient client, ulong steamId)
        {
            var request = new SteamUserRestrictionsRequest(steamId);
            return client.Perform<SteamUserRestrictionsResponse>(request)?.Accounts.Single();
        }

        /// <summary>
        /// Batch-check users' behaviour record
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamIds"><see cref="IEnumerable{T}"/> of user SteamID64s</param>
        /// <returns>Multiple <see cref="SteamUserRestriction"/> object containing the user's record</returns>
        public static IEnumerable<SteamUserRestriction> GetUserRestrictions(this SteamApiClient client, IEnumerable<ulong> steamIds)
        {
            var request = new SteamUserRestrictionsRequest(steamIds);
            return client.Perform<SteamUserRestrictionsResponse>(request)?.Accounts;
        }
    }
}
