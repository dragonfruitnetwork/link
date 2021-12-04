﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamUserTrade
    {
        [JsonProperty("tradeid")]
        public string TradeId { get; set; }

        // todo what's this?
        // ReSharper disable once InconsistentNaming
        [JsonProperty("steamid_other")]
        public string SteamTradeId { get; set; }

        [JsonProperty("time_init")]
        public long TradeStartedEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset TradeStarted => DateTimeOffset.FromUnixTimeSeconds(TradeStartedEpoch);

        // todo int -> enum
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("assets_given")]
        public IEnumerable<SteamUserTradeAsset> AssetsGiven { get; set; }
    }
}
