// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Game.Requests;
using DragonFruit.Link.Game.Responses;
using System.Threading;
using DragonFruit.Common.Data;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGameSchemaExtensions
    {
        /// <summary>
        /// Get achievement and stats information for a specified game.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get the schema for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns></returns>
        public static SteamGameSchemaContainer GetSchemaForGame<T>(this T client, uint appId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameSchemaRequest(appId);
            return client.Perform<SteamGameSchemaResponse>(request, token)?.Schema;
        }
    }
}