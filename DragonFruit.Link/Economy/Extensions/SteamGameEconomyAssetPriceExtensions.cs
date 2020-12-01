// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Threading;
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
        public static IEnumerable<SteamGameEconomyAssetPriceInfo> GetMarketPricesForApp(this SteamApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamGameEconomyAssetPriceRequest(appId);
            return client.Perform<SteamGameEconomyAssetPriceResponse>(request, token)?.PriceInfo.Assets;
        }
    }
}