// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamUserGameServerListingRequest : SteamApiRequest
    {
        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "GetAccountList";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;
    }
}
