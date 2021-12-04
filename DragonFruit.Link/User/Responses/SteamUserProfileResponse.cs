// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserProfileResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserProfileContainer Container { get; set; }
    }

    public class SteamUserProfileContainer
    {
        [JsonProperty("players")]
        public IEnumerable<SteamUserProfile> Profiles { get; set; }
    }
}
