// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserAchievementObject
    {
        [JsonProperty("apiname")]
        public string ApiName { get; set; }

        [JsonProperty("achieved")]
        public bool Achieved { get; set; }

        [JsonProperty("unlocktime")]
        public long UnlockEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset UnlockTime => DateTimeOffset.FromUnixTimeSeconds(UnlockEpoch);
    }
}
