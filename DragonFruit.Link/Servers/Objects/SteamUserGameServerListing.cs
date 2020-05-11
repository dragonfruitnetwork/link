// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Link.Servers.Objects
{
    public class SteamUserGameServerListing
    {
        [JsonProperty("is_banned")]
        public bool AccountBanned { get; set; }

        [JsonProperty("expires")]
        public ulong ExpiresEpoch { get; set; }

        [JsonProperty("last_action_time")]
        public ulong LastActionEpoch { get; set; }

        [JsonProperty("actor")]
        public ulong Actor { get; set; }

#nullable enable

        [JsonProperty("servers")]
        public IEnumerable<SteamGameServerAccountInfo>? Servers { get; set; }

#nullable restore

        [JsonIgnore]
        public DateTimeOffset Expires => DateTimeOffset.UnixEpoch.AddSeconds(ExpiresEpoch);

        [JsonIgnore]
        public DateTimeOffset LastAction => DateTimeOffset.UnixEpoch.AddSeconds(LastActionEpoch);
    }
}
