// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
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
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The offer information and descriptions, or null if the trade id is invalid/party has no involvement</returns>
        public static SteamUserTradeOffer GetTradeOffer<T>(this T client, ulong tradeId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeOfferRequest(tradeId);
            return client.Perform<SteamUserTradeOfferResponse>(request, token)?.OfferLookupResult?.Offer;
        }

        /// <summary>
        /// Get a trade offer by its id. The API key owner must be a party in the trade to return a result
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="tradeId">The id of the trade</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The offer information and descriptions, or null if the trade id is invalid/party has no involvement</returns>
        public static async Task<SteamUserTradeOffer> GetTradeOfferAsync<T>(this T client, ulong tradeId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeOfferRequest(tradeId);
            return (await client.PerformAsync<SteamUserTradeOfferResponse>(request, token).ConfigureAwait(false))?.OfferLookupResult?.Offer;
        }
    }
}
