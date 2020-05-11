// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Store.Requests
{
    public class SteamStoreAppListingRequest : SteamStoreApiRequest, IForSteamApp
    {
        public override string RequestPath => "appdetails";

        public SteamStoreAppListingRequest(uint appId)
        {
            AppId = appId;
        }

        [QueryParameter("appids")]
        public uint AppId { get; set; }
    }
}
