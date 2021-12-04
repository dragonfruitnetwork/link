// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
