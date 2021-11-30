// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;
using System.Threading;
using DragonFruit.Common.Data;

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
    }
}