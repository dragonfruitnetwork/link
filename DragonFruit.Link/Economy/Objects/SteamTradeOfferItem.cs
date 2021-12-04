// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamTradeOfferItem
    {
        [JsonProperty("appid")]
        public uint AppId { get; set; }

        [JsonProperty("contextid")]
        public string ContextId { get; set; }

        [JsonProperty("assetid")]
        public ulong AssetId { get; set; }

        [JsonProperty("classid")]
        public ulong ClassId { get; set; }

        [JsonProperty("instanceid")]
        public ulong InstanceId { get; set; }

        [JsonProperty("amount")]
        public uint Amount { get; set; }

        [JsonProperty("missing")]
        public bool IsMissing { get; set; }

        [JsonProperty("est_usd")]
        public uint EstimatedValue { get; set; }
    }
}
