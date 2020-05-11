// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
