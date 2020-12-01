// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamStoreListingExtensions
    {
        #region All Items

        /// <summary>
        /// Get items (of any kind) listed on the Steam store
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <returns>10,000 Items being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreItems(this SteamApiClient client)
        {
            var request = new SteamStoreListingRequest();
            return client.Perform<SteamStoreListingResponse>(request).Listing;
        }

        /// <summary>
        /// Get items (of any kind) listed on the Steam store
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <returns>Up-to <see cref="maxItems"/> items being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreItems(this SteamApiClient client, uint maxItems)
        {
            var request = new SteamStoreListingRequest
            {
                MaxEntries = maxItems
            };

            return client.Perform<SteamStoreListingResponse>(request).Listing;
        }

        /// <summary>
        /// Get items (of any kind) listed on the Steam store. Picks up from where the last request left off
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="lastItem">Container with the last app id inside (everything else can be empty)</param>
        /// <returns>The next 10,000 items being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreItems(this SteamApiClient client, SteamStoreListingContainer lastItem)
        {
            var request = new SteamStoreListingRequest
            {
                LastAppId = lastItem.LastApp
            };

            return client.Perform<SteamStoreListingResponse>(request)?.Listing;
        }

        /// <summary>
        /// Get items (of any kind) listed on the Steam store. Picks up from where the last request left off
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <returns>Up-to <see cref="maxItems"/> items being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreItems(this SteamApiClient client, uint maxItems, SteamStoreListingContainer lastItem)
        {
            var request = new SteamStoreListingRequest
            {
                LastAppId = lastItem.LastApp,
                MaxEntries = maxItems
            };

            return client.Perform<SteamStoreListingResponse>(request)?.Listing;
        }

        #endregion

        #region Apps & Games

        /// <summary>
        /// Get a list of apps and games listed on the Steam store
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <returns>10,000 apps or games being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreApps(this SteamApiClient client)
        {
            var request = new SteamStoreListingRequest
            {
                IncludeDLC = false,
                IncludeGames = true,
                IncludeHardware = false,
                IncludeSoftware = true,
                IncludeVideos = false
            };

            return client.Perform<SteamStoreListingResponse>(request).Listing;
        }

        /// <summary>
        /// Get a list of apps and games listed on the Steam store
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <returns>Up-to <see cref="maxItems"/> games and apps being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreApps(this SteamApiClient client, uint maxItems)
        {
            var request = new SteamStoreListingRequest
            {
                IncludeDLC = false,
                IncludeGames = true,
                IncludeHardware = false,
                IncludeSoftware = true,
                IncludeVideos = false,

                MaxEntries = maxItems
            };

            return client.Perform<SteamStoreListingResponse>(request).Listing;
        }

        /// <summary>
        /// Get a list of apps and games listed on the Steam store. Picks up from where the last request left off
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="lastItem">Container with the last app id inside (everything else can be empty)</param>
        /// <returns>The next 10,000 apps and games being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreApps(this SteamApiClient client, SteamStoreListingContainer lastItem)
        {
            var request = new SteamStoreListingRequest
            {
                IncludeDLC = false,
                IncludeGames = true,
                IncludeHardware = false,
                IncludeSoftware = true,
                IncludeVideos = false,

                LastAppId = lastItem.LastApp
            };

            return client.Perform<SteamStoreListingResponse>(request)?.Listing;
        }

        /// <summary>
        /// Get a list of apps and games listed on the Steam store. Picks up from where the last request left off
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="maxItems">Max number of entries to be returned</param>
        /// <returns>Up-to <see cref="maxItems"/> games and apps being sold on the Steam store</returns>
        public static SteamStoreListingContainer GetStoreApps(this SteamApiClient client, uint maxItems, SteamStoreListingContainer lastItem)
        {
            var request = new SteamStoreListingRequest
            {
                IncludeDLC = false,
                IncludeGames = true,
                IncludeHardware = false,
                IncludeSoftware = true,
                IncludeVideos = false,

                LastAppId = lastItem.LastApp,
                MaxEntries = maxItems
            };

            return client.Perform<SteamStoreListingResponse>(request)?.Listing;
        }

        #endregion
    }
}
