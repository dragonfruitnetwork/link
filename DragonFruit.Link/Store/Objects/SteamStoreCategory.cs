// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreCategory
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
