// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
