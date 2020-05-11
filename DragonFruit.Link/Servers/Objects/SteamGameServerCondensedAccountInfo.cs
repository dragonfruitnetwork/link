// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        public ulong ExpiresEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset Expires => DateTimeOffset.UnixEpoch.AddSeconds(ExpiresEpoch);
    }
}
