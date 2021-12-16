// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamStoreListingExtensions
    {
        /// <summary>
        /// Get items (of any kind) listed on the Steam store.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="lastItem">The previous result, if the next set is required</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <param name="token">Optional cancellation token</param>
        /// <returns>Up-to <see cref="maxItems"/> items being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreItems<T>(this T client, SteamStoreListingContainer lastItem = null, uint? maxItems = null, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamStoreListingRequest
            {
                LastAppId = lastItem?.LastApp,
                MaxEntries = maxItems
            };

            return client.Perform<SteamStoreListingResponse>(request, token)?.Listing;
        }

        /// <summary>
        /// Get items (of any kind) listed on the Steam store.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="lastItem">The previous result, if the next set is required</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <param name="token">Optional cancellation token</param>
        /// <returns>Up-to <see cref="maxItems"/> items being sold on the Steam store</returns>
        public static async Task<SteamStoreListingContainer> GetStoreItemsAsync<T>(this T client, SteamStoreListingContainer lastItem = null, uint? maxItems = null, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamStoreListingRequest
            {
                LastAppId = lastItem?.LastApp,
                MaxEntries = maxItems
            };

            return (await client.PerformAsync<SteamStoreListingResponse>(request, token).ConfigureAwait(false))?.Listing;
        }

        /// <summary>
        /// Get a list of apps, games and DLCs listed on the Steam store.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="lastItem">The previous result, if the next set is required</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Up-to <see cref="maxItems"/> games and apps being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreApps<T>(this T client, SteamStoreListingContainer lastItem = null, uint? maxItems = null, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamStoreListingRequest
            {
                IncludeDLC = true,
                IncludeGames = true,
                IncludeHardware = false,
                IncludeSoftware = true,
                IncludeVideos = false,

                LastAppId = lastItem?.LastApp,
                MaxEntries = maxItems
            };

            return client.Perform<SteamStoreListingResponse>(request, token)?.Listing;
        }

        /// <summary>
        /// Get a list of apps, games and DLCs listed on the Steam store.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="lastItem">The previous result, if the next set is required</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Up-to <see cref="maxItems"/> games and apps being sold on the Steam store</returns>
        public static async Task<SteamStoreListingContainer> GetStoreAppsAsync<T>(this T client, SteamStoreListingContainer lastItem = null, uint? maxItems = null, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamStoreListingRequest
            {
                IncludeDLC = true,
                IncludeGames = true,
                IncludeHardware = false,
                IncludeSoftware = true,
                IncludeVideos = false,

                LastAppId = lastItem?.LastApp,
                MaxEntries = maxItems
            };

            return (await client.PerformAsync<SteamStoreListingResponse>(request, token).ConfigureAwait(false))?.Listing;
        }
    }
}
