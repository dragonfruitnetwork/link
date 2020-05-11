// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        public ulong Epoch { get; set; }

        public DateTimeOffset Date => DateTimeOffset.UnixEpoch.AddSeconds(Epoch);
    }
}
