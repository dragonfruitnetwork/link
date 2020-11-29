// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Objects;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;
using System.Threading;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeOffersSummaryExtensions
    {
        /// <summary>
        /// Get a summary of trade offers for the API Key owners' account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A summary of the user's trade offers</returns>
        public static SteamUserTradeOffersSummary GetTradeOffersSummary(this SteamApiClient client, CancellationToken token = default)
        {
            var request = new SteamUserTradeOffersSummaryRequest();
            return client.Perform<SteamUserTradeOffersSummaryResponse>(request, token).Summary;
        }
    }
}