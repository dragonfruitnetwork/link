// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
