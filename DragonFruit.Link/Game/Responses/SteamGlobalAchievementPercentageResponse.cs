// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
