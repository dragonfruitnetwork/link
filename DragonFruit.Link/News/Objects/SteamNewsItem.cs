// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.News.Objects
{
    public class SteamNewsItem
    {
        [JsonProperty("gid")]
        public ulong Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_external_url")]
        public bool ExternalUrl { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("contents")]
        public string Body { get; set; }

        [JsonProperty("feedlabel")]
        public string Feed { get; set; }

        [JsonProperty("date")]
        public long Epoch { get; set; }

        public DateTimeOffset Date => DateTimeOffset.FromUnixTimeSeconds(Epoch);
    }
}
