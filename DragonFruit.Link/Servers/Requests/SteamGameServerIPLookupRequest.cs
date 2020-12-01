// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

// ReSharper disable InconsistentNaming

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerIPLookupRequest : SteamApiRequest
    {
        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "GetServerIPsBySteamID";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerIPLookupRequest(IEnumerable<string> steamIds)
        {
            SteamIds = steamIds;
        }

        [QueryParameter("server_steamids", CollectionConversionMode.Concatenated)]
        public IEnumerable<string> SteamIds { get; set; }
    }
}
