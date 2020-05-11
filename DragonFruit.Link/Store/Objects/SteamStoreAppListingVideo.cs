// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
