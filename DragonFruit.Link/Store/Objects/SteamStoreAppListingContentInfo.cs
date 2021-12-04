// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
