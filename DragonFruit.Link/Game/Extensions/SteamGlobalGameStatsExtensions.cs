// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DragonFruit.Common.Data;
using DragonFruit.Link.Exceptions;
using DragonFruit.Link.Game.Requests;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGlobalGameStatsExtensions
    {
        // todo make a strongly-typed response and add async overload
        public static Dictionary<string, double> GetGlobalGameStats(this ApiClient client, uint appId, IEnumerable<string> stats, CancellationToken token = default)
        {
            var request = new SteamGlobalGameStatsRequest(appId, stats);
            var response = client.Perform<JObject>(request, token)["response"];

            if ((bool?)response?["result"] != true)
            {
                throw new SteamRequestFailedException();
            }

            // guaranteed to be present if result = true
            var data = response!["globalstats"];

            return stats.ToDictionary(item => item, item => Convert.ToDouble(data[item]["total"]));
        }
    }
}
