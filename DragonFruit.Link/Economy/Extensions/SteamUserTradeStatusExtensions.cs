// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeStatusExtensions
    {
        /// <summary>
        /// Get the trade history for the API key owner's account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="tradeId">Id of trade to return</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Returns the trade and descriptions of the items included in said trade</returns>
        public static SteamUserTradeHistoryContainer GetTradeStatus<T>(this T client, ulong tradeId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeStatusRequest(tradeId);
            return client.Perform<SteamUserTradeStatusResponse>(request, token)?.History;
        }

        /// <summary>
        /// Get the trade history for the API key owner's account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="tradeId">Id of trade to return</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Returns the trade and descriptions of the items included in said trade</returns>
        public static async Task<SteamUserTradeHistoryContainer> GetTradeStatusAsync<T>(this T client, ulong tradeId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeStatusRequest(tradeId);
            return (await client.PerformAsync<SteamUserTradeStatusResponse>(request, token).ConfigureAwait(false))?.History;
        }
    }
}
