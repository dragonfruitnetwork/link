// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingContentInfo
    {
        [JsonProperty("ids")]
        public IEnumerable<uint> DescriptorIds { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
