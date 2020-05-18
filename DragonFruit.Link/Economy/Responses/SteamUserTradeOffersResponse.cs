// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamUserTradeOffersResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserTradeOffersContainer Offers { get; set; }
    }

    public class SteamUserTradeOffersContainer
    {
        [JsonProperty("trade_offers_sent")]
        public IEnumerable<SteamUserTradeOffer>? Sent { get; set; }

        [JsonProperty("trade_offers_received")]
        public IEnumerable<SteamUserTradeOffer>? Recieved { get; set; }

        [JsonProperty("descriptions")]
        public IEnumerable<SteamGameEconomyAssetDescription> Descriptions { get; set; }
    }
}
