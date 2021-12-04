// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
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
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamUserRestriction"/> object containing the user's record</returns>
        public static SteamUserRestriction GetUserRestrictions<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserRestrictionsRequest(steamId);
            return client.Perform<SteamUserRestrictionsResponse>(request, token)?.Accounts.Single();
        }

        /// <summary>
        /// Check the user's behaviour record for bans
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamUserRestriction"/> object containing the user's record</returns>
        public static async Task<SteamUserRestriction> GetUserRestrictionsAsync<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserRestrictionsRequest(steamId);
            return (await client.PerformAsync<SteamUserRestrictionsResponse>(request, token).ConfigureAwait(false))?.Accounts.Single();
        }

        /// <summary>
        /// Batch-check users' behaviour record
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamIds"><see cref="IEnumerable{T}"/> of user SteamID64s</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Multiple <see cref="SteamUserRestriction"/> object containing the user's record</returns>
        public static IEnumerable<SteamUserRestriction> GetUserRestrictions<T>(this T client, IEnumerable<ulong> steamIds, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserRestrictionsRequest(steamIds);
            return client.Perform<SteamUserRestrictionsResponse>(request, token)?.Accounts;
        }

        /// <summary>
        /// Batch-check users' behaviour record
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamIds"><see cref="IEnumerable{T}"/> of user SteamID64s</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Multiple <see cref="SteamUserRestriction"/> object containing the user's record</returns>
        public static async Task<IEnumerable<SteamUserRestriction>> GetUserRestrictionsAsync<T>(this T client, IEnumerable<ulong> steamIds, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserRestrictionsRequest(steamIds);
            return (await client.PerformAsync<SteamUserRestrictionsResponse>(request, token).ConfigureAwait(false))?.Accounts;
        }
    }
}
