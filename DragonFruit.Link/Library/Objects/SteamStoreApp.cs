// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Objects
{
    public class SteamStoreApp
    {
        [JsonProperty("appid")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_modified")]
        public long LastChangedEpoch { get; set; }

        [JsonProperty("price_change_number")]
        public ulong PriceChangeNumber { get; set; }

        [JsonIgnore]
        public DateTimeOffset LastChanged => DateTimeOffset.FromUnixTimeSeconds(LastChangedEpoch);
    }
}
