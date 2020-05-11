// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserBadge
    {
        [JsonProperty("badgeid")]
        public uint Id { get; set; }

        [JsonProperty("level")]
        public uint BadgeLevel { get; set; }

        [JsonProperty("completion_time")]
        public ulong CompletionTime { get; set; }

        [JsonProperty("xp")]
        public uint TotalXPGained { get; set; }

        [JsonProperty("scarcity")]
        public uint Scarcity { get; set; }
    }
}
