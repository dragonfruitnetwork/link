// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingReleaseInfo
    {
        [JsonProperty("coming_soon")]
        public bool IsUnreleased { get; set; }

        [JsonProperty("date")]
        public DateTime ReleaseDate { get; set; }
    }
}
