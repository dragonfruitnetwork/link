// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamGameEconomyAssetPriceInfo
    {
        [JsonProperty("prices")]
        private JObject RawPrices
        {
            set
            {
                var list = new Dictionary<string, uint>(value.Count);

                foreach (var item in value)
                {
                    if (item.Key == "Unknown")
                    {
                        continue;
                    }

                    list.Add(item.Key, (uint)item.Value);
                }

                Prices = list;
            }
        }

        public IDictionary<string, uint> Prices { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("classid")]
        public string ClassId { get; set; }

        [JsonProperty("class")]
        public IEnumerable<SteamGameEconomyClassInfo> ClassInfo { get; set; }
    }

    public class SteamGameEconomyClassInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
