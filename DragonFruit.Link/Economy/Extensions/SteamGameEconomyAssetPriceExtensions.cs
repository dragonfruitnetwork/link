// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Economy.Objects;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamGameEconomyAssetPriceExtensions
    {
        /// <summary>
        /// Get the community market prices for all items offered by a specific app
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get market info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A list of all the items and their prices in various currencies</returns>
        public static IEnumerable<SteamGameEconomyAssetPriceInfo> GetMarketPricesForApp<T>(this T client, uint appId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameEconomyAssetPriceRequest(appId);
            return client.Perform<SteamGameEconomyAssetPriceResponse>(request, token)?.PriceInfo.Assets;
        }

        /// <summary>
        /// Get the community market prices for all items offered by a specific app
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get market info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A list of all the items and their prices in various currencies</returns>
        public static async Task<IEnumerable<SteamGameEconomyAssetPriceInfo>> GetMarketPricesForAppAsync<T>(this T client, uint appId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameEconomyAssetPriceRequest(appId);
            return (await client.PerformAsync<SteamGameEconomyAssetPriceResponse>(request, token).ConfigureAwait(false))?.PriceInfo.Assets;
        }
    }
}
