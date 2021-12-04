// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamUserTradeOffersSummaryResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserTradeOffersSummary Summary { get; set; }
    }
}
