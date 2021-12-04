// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingAchievementsContainer
    {
        [JsonProperty("total")]
        public uint Total { get; set; }

        [JsonProperty("highlighted")]
        public IEnumerable<SteamStoreAppListingAchievements> HighlightedAchievements { get; set; }
    }

    public class SteamStoreAppListingAchievements
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string IconPath { get; set; }
    }
}
