// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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