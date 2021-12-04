// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingVideo
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("highlight")]
        public bool Highlight { get; set; }

        [JsonProperty("webm")]
        public SteamStoreAppListingVideoSourceContainer Videos { get; set; }
    }

    public class SteamStoreAppListingVideoSourceContainer
    {
        [JsonProperty("480")]
        public string LowQuality { get; set; }

        [JsonProperty("max")]
        public string MaxQuality { get; set; }
    }
}
