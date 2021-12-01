// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeHoldDurationExtensions
    {
        /// <summary>
        /// Get the estimated trade hold between the API key owner and another user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="targetUser">The SteamID of the target</param>
        /// <param name="targetToken">The `token` parameter of the user's Trade URL</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The info of all parties' hold durations and a final one that will be used in the real trade</returns>
        public static SteamUserTradeHoldDurationContainer GetTradeHoldDurations<T>(this T client, ulong targetUser, string targetToken, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeHoldDurationRequest(targetUser, targetToken);
            return client.Perform<SteamUserTradeHoldDurationResponse>(request, token)?.HoldDurations;
        }

        /// <summary>
        /// Get the estimated trade hold between the API key owner and another user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="targetUser">The SteamID of the target</param>
        /// <param name="targetToken">The `token` parameter of the user's Trade URL</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The info of all parties' hold durations and a final one that will be used in the real trade</returns>
        public static async Task<SteamUserTradeHoldDurationContainer> GetTradeHoldDurationsAsync<T>(this T client, ulong targetUser, string targetToken, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeHoldDurationRequest(targetUser, targetToken);
            return (await client.PerformAsync<SteamUserTradeHoldDurationResponse>(request, token).ConfigureAwait(false))?.HoldDurations;
        }
    }
}
