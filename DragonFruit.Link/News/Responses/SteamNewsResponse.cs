// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.News.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.News.Responses
{
    public class SteamNewsResponse : ISteamApiResponse
    {
        [JsonProperty("appnews")]
        public SteamNewsContainer Container { get; set; }
    }
}
