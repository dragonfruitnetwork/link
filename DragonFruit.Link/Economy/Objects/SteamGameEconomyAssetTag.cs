// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        public string? Colour { get; set; }
    }
}
