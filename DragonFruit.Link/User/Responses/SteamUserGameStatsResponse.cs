// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserGameStatsResponse : ISteamApiResponse
    {
        [JsonProperty("playerstats")]
        public SteamUserGameStatsContainer Player { get; set; }
    }

    public class SteamUserGameStatsContainer
    {
        [JsonProperty("steamID")]
        public ulong Id { get; set; }

        [JsonProperty("gameName")]
        public string GameName { get; set; }

        [JsonProperty("stats")]
        public IEnumerable<SteamUserGameStatsObject> Stats { get; set; }

        [JsonProperty("achievements")]
        public IEnumerable<SteamUserGameStatsAchievementObject>? Achievements { get; set; }
    }
}
