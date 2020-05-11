// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Objects;
using DragonFruit.Link.Servers.Requests;
using DragonFruit.Link.Servers.Responses;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamUserGameServerListingExtensions
    {
        /// <summary>
        /// Get the API key owner's steam game servers
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <returns>The API key owner's account standing and any server they have registered, for all games</returns>
        public static SteamUserGameServerListing GetGameServers(this SteamApiClient client)
        {
            var request = new SteamUserGameServerListingRequest();
            return client.Perform<SteamUserGameServerListingResponse>(request).ServerListing;
        }
    }
}
