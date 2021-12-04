// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamUserTradeOffersResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserTradeOffersContainer? Offers { get; set; }
    }

    public class SteamUserTradeOffersContainer
    {
        [JsonProperty("trade_offers_sent")]
        public IEnumerable<SteamUserTradeOffer>? Sent { get; set; }

        [JsonProperty("trade_offers_received")]
        public IEnumerable<SteamUserTradeOffer>? Recieved { get; set; }

        [JsonProperty("descriptions")]
        public IEnumerable<SteamGameEconomyAssetDescription>? Descriptions { get; set; }
    }
}
