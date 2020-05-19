// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Library.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Responses
{
    public class SteamSharedGameCheckResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamSharedGameLenderInfo? LenderInfo { get; set; }
    }
}
