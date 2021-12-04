// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingPriceOverview
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("initial")]
        public uint InitialPrice { get; set; }

        [JsonProperty("final")]
        public uint FinalPrice { get; set; }

        [JsonProperty("discount_percent")]
        public uint PercentageDiscount { get; set; }

        [JsonProperty("initial_formatted")]
        public string InitialPriceFormatted { get; set; }

        [JsonProperty("final_formatted")]
        public string FinalPriceFormatted { get; set; }
    }
}
