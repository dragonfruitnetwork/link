// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using System.Linq;
using DragonFruit.Common.Data;
using DragonFruit.Link.Game.Requests;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGlobalGameStatsExtensions
    {
        public static Dictionary<string, double> GetGlobalGameStats(this ApiClient client, uint appId, params string[] stats)
        {
            var request = new SteamGlobalGameStatsRequest(appId, stats);
            var response = client.Perform<JObject>(request)["response"]!;

            if (!(bool)response!["result"])
            {
                throw new Exception("Request failed");
            }

            var data = response["globalstats"]!;

            return stats.ToDictionary(item => item, item => Convert.ToDouble(data![item]!["total"]));
        }
    }
}
