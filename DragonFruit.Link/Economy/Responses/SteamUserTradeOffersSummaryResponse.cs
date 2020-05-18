// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
