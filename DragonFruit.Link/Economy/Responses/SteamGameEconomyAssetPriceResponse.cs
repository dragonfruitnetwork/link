// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamGameEconomyAssetPriceResponse : ISteamApiResponse
    {
        [JsonProperty("result")]
        public SteamGameEconomyAssetPriceContainer PriceInfo { get; set; }
    }

    public class SteamGameEconomyAssetPriceContainer
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("assets")]
        public IEnumerable<SteamGameEconomyAssetPriceInfo> Assets { get; set; }
    }
}
