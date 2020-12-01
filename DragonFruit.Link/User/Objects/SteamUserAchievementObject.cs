// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
