// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
