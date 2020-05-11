// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
