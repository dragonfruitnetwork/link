// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppRequirements
    {
        [JsonProperty("minimum")]
        public string HtmlMinimum { get; set; }

        [JsonProperty("recommended")]
        public string HtmlRecommended { get; set; }
    }
}
