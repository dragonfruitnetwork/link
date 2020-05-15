// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        /// <returns>Returns up-to the <see cref="maxEntries"/> of trades and descriptions of the items in referenced trades</returns>
        public static SteamUserTradeHistoryContainer GetTradeHistory(this SteamApiClient client, uint maxEntries)
        {
            var request = new SteamUserTradeHistoryRequest(maxEntries);
            return client.Perform<SteamUserTradeHistoryResponse>(request).History;
        }
    }
}
