// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Data;
using DragonFruit.Data.Parameters;

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
