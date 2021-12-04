// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
