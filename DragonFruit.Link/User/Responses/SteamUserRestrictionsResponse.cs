// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserRestrictionsResponse : ISteamApiResponse
    {
        [JsonProperty("players")]
        public IEnumerable<SteamUserRestriction> Accounts { get; set; }
    }
}
