// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

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
