// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
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
        public string IconUrlLarge { get; set; }

        [JsonProperty("icon_drag_url")]
        public string IconDragUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("market_name")]
        public string MarketName { get; set; }

        [JsonProperty("name_color")]
        public string MarketNameColour { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColour { get; set; }

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

        [JsonProperty("description_list")]
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
                switch (value)
                {
                    case JArray arr:
                    {
                        var list = new List<SteamGameEconomyAssetDescription>(arr.Count);

                        list.AddRange(arr.Select(item => item.ToObject<SteamGameEconomyAssetDescription>()));

                        Descriptions = list;
                        break;
                    }

                    case JObject obj:
                    {
                        var list = new List<SteamGameEconomyAssetDescription>(obj.Count);

                        foreach (var item in obj)
                        {
                            list.Add(item.Value.ToObject<SteamGameEconomyAssetDescription>());
                        }

                        Descriptions = list;
                        break;
                    }

                    default:
                    {
                        throw new NotSupportedException();
                    }
                }
            }
        }
    }
}
