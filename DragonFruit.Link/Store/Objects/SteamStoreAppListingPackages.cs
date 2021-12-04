// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingPackages
    {
        [JsonProperty("packageid")]
        public uint Id { get; set; }

        [JsonProperty("percent_savings_text")]
        public string PercentageSavingsText { get; set; }

        [JsonProperty("percent_savings")]
        public float PercentageSavings { get; set; }

        [JsonProperty("option_text")]
        public string Title { get; set; }

        [JsonProperty("option_description")]
        public string Description { get; set; }

        [JsonProperty("is_free_license")]
        public bool IsFree { get; set; }

        //todo work out what this **actually** does
        [JsonProperty("can_get_free_license")]
        public string CanGetFreeLicense { get; set; }

        /// <summary>
        /// The Price of the subscription, after the <see cref="PercentageSavings"/> is applied
        /// </summary>
        [JsonProperty("price_in_cents_with_discount")]
        public uint PricePostDiscount { get; set; }

        /// <summary>
        /// Calculated Original Price, before the discount
        /// </summary>
        [JsonIgnore]
        public float Price => PricePostDiscount / (1 - PercentageSavings / 100);
    }
}
