// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Store.Objects
{
    public class SteamFeaturedCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("items")]
        public IEnumerable<SteamFeaturedCategoryItem>? Items { get; set; }
    }

    public class SteamFeaturedCategoryItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("header_image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
