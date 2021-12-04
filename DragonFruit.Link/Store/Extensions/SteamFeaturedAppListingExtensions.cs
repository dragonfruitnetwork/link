// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Store.Requests;
using DragonFruit.Link.Store.Responses;

namespace DragonFruit.Link.Store.Extensions
{
    public static class SteamFeaturedAppListingExtensions
    {
        /// <summary>
        /// Get the apps listed on the front of the Steam store - the featured apps
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        public static SteamFeaturedAppListingResponse GetFeaturedAppListing(this ApiClient client)
        {
            return client.Perform<SteamFeaturedAppListingResponse>(new SteamFeaturedAppListingRequest());
        }

        /// <summary>
        /// Get the apps listed on the front of the Steam store - the featured apps
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        public static Task<SteamFeaturedAppListingResponse> GetFeaturedAppListingAsync(this ApiClient client)
        {
            return client.PerformAsync<SteamFeaturedAppListingResponse>(new SteamFeaturedAppListingRequest());
        }
    }
}
