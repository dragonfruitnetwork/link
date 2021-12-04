// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Game.Objects
{
    public class SteamGameCurrentPlayersMetric
    {
        [JsonProperty("result")]
        public bool Success { get; set; }

        [JsonProperty("player_count")]
        public uint CurrentPlayers { get; set; }
    }
}
