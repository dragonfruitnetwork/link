// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Library.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Responses
{
    public class SteamAppsListingResponse : ISteamApiResponse
    {
        [JsonProperty("applist")]
        public SteamAppsListingContainer Listing { get; set; }
    }

    public class SteamAppsListingContainer
    {
        [JsonProperty("apps")]
        public IEnumerable<SteamBasicSteamApp> Apps { get; set; }
    }
}
