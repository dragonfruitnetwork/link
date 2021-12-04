// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserLinkResolveResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserLink LinkInfo { get; set; }
    }
}
