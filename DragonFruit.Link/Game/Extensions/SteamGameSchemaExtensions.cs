﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
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
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns></returns>
        public static SteamGameSchemaContainer GetSchemaForGame<T>(this T client, uint appId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameSchemaRequest(appId);
            return client.Perform<SteamGameSchemaResponse>(request, token)?.Schema;
        }

        /// <summary>
        /// Get achievement and stats information for a specified game.
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get the schema for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns></returns>
        public static async Task<SteamGameSchemaContainer> GetSchemaForGameAsync<T>(this T client, uint appId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameSchemaRequest(appId);
            return (await client.PerformAsync<SteamGameSchemaResponse>(request, token).ConfigureAwait(false))?.Schema;
        }
    }
}
