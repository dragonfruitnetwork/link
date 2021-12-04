// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Game.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Game.Responses
{
    public class SteamGameCurrentPlayersResponse
    {
        [JsonProperty("response")]
        public SteamGameCurrentPlayersMetric? TotalPlayerInfo { get; set; }
    }
}
