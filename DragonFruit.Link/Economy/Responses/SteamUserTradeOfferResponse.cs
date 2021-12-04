// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamUserTradeOfferResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserTradeOfferContainer? OfferLookupResult { get; set; }
    }

    public class SteamUserTradeOfferContainer
    {
        [JsonProperty("offer")]
        public SteamUserTradeOffer Offer { get; set; }

        [JsonProperty("descriptions")]
        public IEnumerable<SteamGameEconomyAsset>? Descriptions { get; set; }
    }
}
