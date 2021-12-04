// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserGameStatsObject
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
