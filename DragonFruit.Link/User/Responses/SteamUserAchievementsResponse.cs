// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserAchievementsResponse : ISteamApiResponse
    {
        [JsonProperty("playerstats")]
        public SteamUserAchievementsContainer Player { get; set; }
    }

    public class SteamUserAchievementsContainer
    {
        [JsonProperty("steamID")]
        public ulong Id { get; set; }

        [JsonProperty("gameName")]
        public string GameName { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("achievements")]
        public IEnumerable<SteamUserAchievementObject> Achievements { get; set; }
    }
}
