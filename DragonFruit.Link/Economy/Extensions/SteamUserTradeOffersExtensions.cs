// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeOffersExtensions
    {
        /// <summary>
        /// Get a collection of all outstanding trades (sent or received) to this account. Includes Item descriptions
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A collection of sent and received offers, with their item descriptions</returns>
        public static SteamUserTradeOffersContainer GetTrades<T>(this T client, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeOffersRequest();
            return client.Perform<SteamUserTradeOffersResponse>(request, token)?.Offers;
        }

        /// <summary>
        /// Get a collection of all outstanding trades (sent or received) to this account. Includes Item descriptions
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A collection of sent and received offers, with their item descriptions</returns>
        public static async Task<SteamUserTradeOffersContainer> GetTradesAsync<T>(this T client, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserTradeOffersRequest();
            return (await client.PerformAsync<SteamUserTradeOffersResponse>(request, token).ConfigureAwait(false))?.Offers;
        }
    }
}
