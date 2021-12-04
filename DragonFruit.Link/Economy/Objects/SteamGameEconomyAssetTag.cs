// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamGameEconomyAssetTag
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("color")]
        public string Colour { get; set; }
    }
}
