// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamUserTradeHistoryResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserTradeHistoryContainer History { get; set; }
    }

    public class SteamUserTradeHistoryContainer
    {
        [JsonProperty("more")]
        public bool? More { get; set; }

        [JsonProperty("total_trades")]
        public uint? TotalTrades { get; set; }

        [JsonProperty("trades")]
        public IEnumerable<SteamUserTrade>? Trades { get; set; }

        [JsonProperty("descriptions")]
        public IEnumerable<SteamGameEconomyAsset>? Descriptions { get; set; }
    }
}
