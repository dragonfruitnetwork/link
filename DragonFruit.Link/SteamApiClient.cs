// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Serializers;

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
