// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;
using System.Threading;

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
        public static SteamUserTradeHistoryContainer GetTradeStatus(this SteamApiClient client, ulong tradeId, CancellationToken token = default)
        {
            var request = new SteamUserTradeStatusRequest(tradeId);
            return client.Perform<SteamUserTradeStatusResponse>(request, token).History;
        }
    }
}