﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

namespace DragonFruit.Link.Store.Requests
{
    public class SteamFeaturedAppListingRequest : SteamStoreApiRequest
    {
        public override string RequestPath => "featured";
    }
}
