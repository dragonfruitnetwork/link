// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
