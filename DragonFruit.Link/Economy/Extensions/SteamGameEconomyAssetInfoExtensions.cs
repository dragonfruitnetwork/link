// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Economy.Objects;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamGameEconomyAssetInfoExtensions
    {
        /// <summary>
        /// Get the basic info (excluding prices) for specific market items belonging to an app
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id the market items belong to</param>
        /// <param name="items">An <see cref="IEnumerable{T}"/> of items to get info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The assets requested in the <see cref="items"/> argument</returns>
        public static IEnumerable<SteamGameEconomyAsset> GetMarketItemsForApp<T>(this T client, uint appId, IEnumerable<ulong> items, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameEconomyAssetInfoRequest(appId, items);
            return client.Perform<SteamGameEconomyAssetInfoResponse>(request, token)?.Assets;
        }

        /// <summary>
        /// Get the basic info (excluding prices) for specific market items belonging to an app
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id the market items belong to</param>
        /// <param name="items">An <see cref="IEnumerable{T}"/> of items to get info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The assets requested in the <see cref="items"/> argument</returns>
        public static async Task<IEnumerable<SteamGameEconomyAsset>> GetMarketItemsForAppAsync<T>(this T client, uint appId, IEnumerable<ulong> items, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameEconomyAssetInfoRequest(appId, items);
            return (await client.PerformAsync<SteamGameEconomyAssetInfoResponse>(request, token).ConfigureAwait(false))?.Assets;
        }
    }
}
