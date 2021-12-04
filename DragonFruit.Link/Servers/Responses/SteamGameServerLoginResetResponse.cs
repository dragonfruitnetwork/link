// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Servers.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Servers.Responses
{
    public class SteamGameServerLoginResetResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamGameServerAccountInfo AccountInfo { get; set; }
    }
}
