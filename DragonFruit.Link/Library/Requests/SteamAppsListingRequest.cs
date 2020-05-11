// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
