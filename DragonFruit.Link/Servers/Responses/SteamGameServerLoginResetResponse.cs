// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Servers.Responses
{
    public class SteamGameServerLoginResetResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamGameServerAccountInfo? AccountInfo { get; set; }
    }
}
