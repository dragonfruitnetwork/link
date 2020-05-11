// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
