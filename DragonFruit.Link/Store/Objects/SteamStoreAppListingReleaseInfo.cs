// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
