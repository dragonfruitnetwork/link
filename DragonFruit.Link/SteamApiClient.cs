﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data;
using DragonFruit.Data.Serializers.Newtonsoft;

namespace DragonFruit.Link
{
    public class SteamApiClient : ApiClient<ApiJsonSerializer>, ISteamApiClient
    {
        public SteamApiClient(string api)
        {
            ApiKey = api;
        }

        /// <summary>
        /// The api key to use in authenticated requests
        /// </summary>
        public string ApiKey { get; }
    }
}
