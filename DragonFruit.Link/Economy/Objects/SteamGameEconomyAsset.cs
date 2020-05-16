// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamGameEconomyAsset
    {
        [JsonProperty("classid")]
        public ulong ClassId { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("icon_url_large")]
        public string? IconUrlLarge { get; set; }

        [JsonProperty("icon_drag_url")]
        public string? IconDragUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("market_name")]
        public string MarketName { get; set; }

        [JsonProperty("name_color")]
        public string MarketNameColour { get; set; }

        [JsonProperty("background_color")]
        public string? BackgroundColour { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        //todo can be changed to bool?
        [JsonProperty("tradable")]
        public uint IsTradable { get; set; }

        //todo can be changed to bool?
        [JsonProperty("marketable")]
        public uint IsMarketable { get; set; }

        //todo can be changed to bool?
        [JsonProperty("commodity")]
        public uint IsCommodity { get; set; }

        [JsonProperty("market_tradable_restriction")]
        public uint MarketTradeRestriction { get; set; }

        [JsonProperty("fraudwarnings")]
        public IEnumerable<string>? FraudWarnings { get; set; }

        [JsonProperty("tags_list")]
        public IEnumerable<SteamGameEconomyAssetTag> Tags { get; set; }

        [JsonProperty("descriptions_list")]
        public IEnumerable<SteamGameEconomyAssetDescription> Descriptions { get; set; }

        [JsonProperty("tags")]
        private JObject TagsObject
        {
            set
            {
                var list = new List<SteamGameEconomyAssetTag>(value.Count);

                foreach (var item in value)
                {
                    list.Add(item.Value.ToObject<SteamGameEconomyAssetTag>());
                }

                Tags = list;
            }
        }

        [JsonProperty("descriptions")]
        private JToken DescriptionsObject
        {
            set
            {
                var list = new List<SteamGameEconomyAssetDescription>(value.Count());

                foreach (var jToken in value)
                {
                    var item = (JObject)jToken;
                    list.Add(item.ToObject<SteamGameEconomyAssetDescription>());
                }

                Descriptions = list;
            }
        }
    }
}
