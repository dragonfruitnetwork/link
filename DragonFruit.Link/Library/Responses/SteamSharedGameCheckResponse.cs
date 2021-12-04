// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Library.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Responses
{
    public class SteamSharedGameCheckResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamSharedGameLenderInfo LenderInfo { get; set; }
    }
}
