// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Game.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Game.Responses
{
    public class SteamGlobalAchievementPercentageResponse : ISteamApiResponse
    {
        [JsonProperty("achievementpercentages")]
        public SteamGameAchievementPercentageContainer Global { get; set; }
    }

    public class SteamGameAchievementPercentageContainer
    {
        [JsonProperty("achievements")]
        public IEnumerable<SteamAchievementUnlockMetric> Achievements { get; set; }
    }
}
