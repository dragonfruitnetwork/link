// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Servers.Objects
{
    public class SteamGameServerAccountInfo
    {
        [JsonProperty("steamid")]
        public ulong Id { get; set; }

        [JsonProperty("appid")]
        public uint AppId { get; set; }

        [JsonProperty("login_token")]
        public string ServerToken { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("is_deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("is_expired")]
        public bool Expired { get; set; }

        [JsonProperty("rt_last_logon")]
        public long LastLogonEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset LastLogon => DateTimeOffset.FromUnixTimeSeconds(LastLogonEpoch);
    }
}
