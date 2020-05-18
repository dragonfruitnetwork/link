// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Objects;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeOfferExtensions
    {
        /// <summary>
        /// Get a trade offer by its id. The API key owner must be a party in the trade to return a result
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="tradeId">The id of the trade</param>
        /// <returns>The offer information and descriptions, or null if the trade id is invalid/party has no involvement</returns>
        public static SteamUserTradeOffer GetTradeOffer(this SteamApiClient client, ulong tradeId)
        {
            var request = new SteamUserTradeOfferRequest(tradeId);
            return client.Perform<SteamUserTradeOfferResponse>(request).OfferLookupResult?.Offer;
        }
    }
}
