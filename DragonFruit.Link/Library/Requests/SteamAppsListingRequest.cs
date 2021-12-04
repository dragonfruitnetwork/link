// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

namespace DragonFruit.Link.Library.Requests
{
    public class SteamAppsListingRequest : SteamApiRequest
    {
        public override string Interface => "ISteamApps";
        public override string InterfaceMethod => "GetAppList";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => false;
    }
}
