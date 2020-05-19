// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
