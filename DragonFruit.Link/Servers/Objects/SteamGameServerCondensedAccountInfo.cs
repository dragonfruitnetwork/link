// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Servers.Objects
{
    public class SteamGameServerCondensedAccountInfo
    {
        [JsonProperty("steamid")]
        public ulong Id { get; set; }

        [JsonProperty("is_banned")]
        public bool Banned { get; set; }

        [JsonProperty("expires")]
        public long ExpiresEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset Expires => DateTimeOffset.FromUnixTimeSeconds(ExpiresEpoch);
    }
}
