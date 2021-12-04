// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Store.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Responses
{
    public class SteamFeaturedAppListingResponse : ISteamApiResponse
    {
        [JsonProperty("large_capsules")]
        public IEnumerable<SteamFeaturedAppListing> LargeCapsules { get; set; }

        [JsonProperty("featured_win")]
        public IEnumerable<SteamFeaturedAppListing> Windows { get; set; }

        [JsonProperty("featured_linux")]
        public IEnumerable<SteamFeaturedAppListing> Linux { get; set; }

        [JsonProperty("featured_mac")]
        public IEnumerable<SteamFeaturedAppListing> Mac { get; set; }

        [JsonProperty("status")]
        public bool Success { get; set; }
    }
}
