// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
