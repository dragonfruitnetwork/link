// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Library.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Responses
{
    public class SteamStoreListingResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamStoreListingContainer? Listing { get; set; }
    }

    public class SteamStoreListingContainer
    {
        [JsonProperty("have_more_results")]
        public bool MoreItemsAvailable { get; set; }

        [JsonProperty("last_appid")]
        public uint LastApp { get; set; }

        [JsonProperty("apps")]
        public IEnumerable<SteamStoreApp> Apps { get; set; }
    }
}
