// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Linq;
using DragonFruit.Data;
using DragonFruit.Data.Parameters;

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
        public int QueryCount => Queries.Count();

        [QueryParameter("name", CollectionConversionMode.Ordered)]
        public IEnumerable<string> Queries { get; set; }
    }
}
