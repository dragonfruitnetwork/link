// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerIdLookupRequest : SteamApiRequest
    {
        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "GetServerSteamIDsByIP";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerIdLookupRequest(IEnumerable<string> ips)
        {
            IpAddresses = ips;
        }

        [QueryParameter("server_ips", CollectionConversionMode.Concatenated)]
        public IEnumerable<string> IpAddresses { get; set; }
    }
}
