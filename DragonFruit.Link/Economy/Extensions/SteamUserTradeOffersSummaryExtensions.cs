// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Economy.Objects;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

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
        public static SteamUserTradeOffersSummary GetTradeOffersSummary<T>(this T client, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeOffersSummaryRequest();
            return client.Perform<SteamUserTradeOffersSummaryResponse>(request, token)?.Summary;
        }

        /// <summary>
        /// Get a summary of trade offers for the API Key owners' account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A summary of the user's trade offers</returns>
        public static async Task<SteamUserTradeOffersSummary> GetTradeOffersSummaryAsync<T>(this T client, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeOffersSummaryRequest();
            return (await client.PerformAsync<SteamUserTradeOffersSummaryResponse>(request, token).ConfigureAwait(false))?.Summary;
        }
    }
}
