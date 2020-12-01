﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
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
        public long ExpiresEpoch { get; set; }

        [JsonProperty("last_action_time")]
        public long LastActionEpoch { get; set; }

        [JsonProperty("actor")]
        public ulong Actor { get; set; }

        [JsonProperty("servers")]
        public IEnumerable<SteamGameServerAccountInfo> Servers { get; set; }

        [JsonIgnore]
        public DateTimeOffset Expires => DateTimeOffset.FromUnixTimeSeconds(ExpiresEpoch);

        [JsonIgnore]
        public DateTimeOffset LastAction => DateTimeOffset.FromUnixTimeSeconds(LastActionEpoch);
    }
}
