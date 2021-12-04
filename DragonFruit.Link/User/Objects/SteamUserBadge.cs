// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
