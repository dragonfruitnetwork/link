// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingMetacriticReview
    {
        [JsonProperty("score")]
        public uint Score { get; set; }

        [JsonProperty("url")]
        public string ReviewUrl { get; set; }
    }
}
