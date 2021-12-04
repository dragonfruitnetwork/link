// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

namespace DragonFruit.Link.Store.Requests
{
    public class SteamFeaturedAppListingRequest : SteamStoreApiRequest
    {
        public override string RequestPath => "featured";
    }
}
