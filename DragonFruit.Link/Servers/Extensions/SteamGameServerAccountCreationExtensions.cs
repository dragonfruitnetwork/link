﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Objects;
using DragonFruit.Link.Servers.Requests;
using DragonFruit.Link.Servers.Responses;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerAccountCreationExtensions
    {
        /// <summary>
        /// Registers a Steam Game server to the API key owner's account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id the server is for</param>
        /// <param name="memo">The note attached to the server, for personal reference.</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The login info for the server</returns>
        public static SteamGameServerAccountLoginInfo CreateGameServer<T>(this T client, uint appId, string memo, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerAccountCreationRequest(appId, memo);
            return client.Perform<SteamGameServerAccountCreationResponse>(request, token)?.AccountLoginInfo;
        }

        /// <summary>
        /// Registers a Steam Game server to the API key owner's account
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id the server is for</param>
        /// <param name="memo">The note attached to the server, for personal reference.</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The login info for the server</returns>
        public static async Task<SteamGameServerAccountLoginInfo> CreateGameServerAsync<T>(this T client, uint appId, string memo, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerAccountCreationRequest(appId, memo);
            return (await client.PerformAsync<SteamGameServerAccountCreationResponse>(request, token).ConfigureAwait(false))?.AccountLoginInfo;
        }
    }
}
