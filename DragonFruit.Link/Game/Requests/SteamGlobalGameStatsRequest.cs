// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using System.Linq;
using System.Text;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Game.Requests
{
    public class SteamGlobalGameStatsRequest : SteamApiRequest, IForSteamApp
    {
        public override string Interface => "ISteamUserStats";
        public override string InterfaceMethod => "GetGlobalStatsForGame";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => false;

        public SteamGlobalGameStatsRequest(uint appId, string query)
        {
            AppId = appId;
            Queries = new[] { query };
        }

        public SteamGlobalGameStatsRequest(uint appId, IEnumerable<string> queries)
        {
            AppId = appId;
            Queries = queries;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("count")]
        private string CompiledQueries
        {
            get
            {
                var stringBuilder = new StringBuilder();
                var totalQueries = Queries.Count();

                stringBuilder.Append(totalQueries);

                for (var i = 0; i < totalQueries; i++)
                {
                    stringBuilder.Append($"&name[{i}]={Queries.ElementAt(i)}");
                }

                return stringBuilder.ToString();
            }
        }

        public IEnumerable<string> Queries { get; set; }
    }
}
