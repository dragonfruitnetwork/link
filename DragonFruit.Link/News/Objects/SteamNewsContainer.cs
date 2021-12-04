// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Link.News.Objects
{
    public class SteamNewsContainer
    {
        [JsonProperty("appid")]
        public uint AppId { get; set; }

        [JsonProperty("count")]
        public uint TotalItems { get; set; }

        [JsonProperty("newsitems")]
        public IEnumerable<SteamNewsItem> Items { get; set; }
    }
}
