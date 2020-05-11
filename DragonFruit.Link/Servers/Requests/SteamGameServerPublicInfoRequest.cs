// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerPublicInfoRequest : SteamApiRequest, IForSteamUser
    {
        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "GetAccountPublicInfo";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerPublicInfoRequest(ulong steamId)
        {
            Id = steamId;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }
    }
}
