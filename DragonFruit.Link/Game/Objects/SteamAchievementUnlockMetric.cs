// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Game.Objects
{
    public class SteamAchievementUnlockMetric
    {
        [JsonProperty("name")]
        public string Id { get; set; }

        [JsonProperty("percent")]
        public float PercentageUnlocked { get; set; }
    }
}
