// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamUserTradeAsset : IForSteamApp
    {
        [JsonProperty("appid")]
        public uint AppId { get; set; }

        [JsonProperty("contextid")]
        public ulong ContextId { get; set; }

        [JsonProperty("new_contextid")]
        public ulong NewContextId { get; set; }

        [JsonProperty("assetid")]
        public ulong AssetId { get; set; }

        [JsonProperty("new_assetid")]
        public ulong NewAssetId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("classid")]
        public ulong ClassId { get; set; }

        [JsonProperty("instanceid")]
        public ulong InstanceId { get; set; }
    }
}
