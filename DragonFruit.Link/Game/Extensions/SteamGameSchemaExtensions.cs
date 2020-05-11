// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Game.Requests;
using DragonFruit.Link.Game.Responses;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGameSchemaExtensions
    {
        /// <summary>
        /// Get achievement and stats information for a specified game.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get the schema for</param>
        /// <returns></returns>
        public static SteamGameSchemaContainer GetSchemaForGame(this SteamApiClient client, uint appId)
        {
            var request = new SteamGameSchemaRequest(appId);
            return client.Perform<SteamGameSchemaResponse>(request).Schema;
        }
    }
}
