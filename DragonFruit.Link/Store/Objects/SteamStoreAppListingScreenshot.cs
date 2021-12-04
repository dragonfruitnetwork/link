// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingScreenshot
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("path_thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("path_full")]
        public string Full { get; set; }
    }
}
