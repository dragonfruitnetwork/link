// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
    }
}
