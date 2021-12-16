// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeHistoryExtensions
    {
        /// <summary>
        /// Get the trade history for the API key owner's account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="maxEntries">Max number of trades to return</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Returns up-to the <see cref="maxEntries"/> of trades and descriptions of the items in referenced trades</returns>
        public static SteamUserTradeHistoryContainer GetTradeHistory<T>(this T client, uint maxEntries, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeHistoryRequest(maxEntries);
            return client.Perform<SteamUserTradeHistoryResponse>(request, token)?.History;
        }

        /// <summary>
        /// Get the trade history for the API key owner's account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="maxEntries">Max number of trades to return</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Returns up-to the <see cref="maxEntries"/> of trades and descriptions of the items in referenced trades</returns>
        public static async Task<SteamUserTradeHistoryContainer> GetTradeHistoryAsync<T>(this T client, uint maxEntries, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeHistoryRequest(maxEntries);
            return (await client.PerformAsync<SteamUserTradeHistoryResponse>(request, token).ConfigureAwait(false))?.History;
        }
    }
}
