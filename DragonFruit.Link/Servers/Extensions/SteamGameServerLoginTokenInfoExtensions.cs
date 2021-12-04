// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Servers.Objects;
using DragonFruit.Link.Servers.Requests;
using DragonFruit.Link.Servers.Responses;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerLoginTokenInfoExtensions
    {
        /// <summary>
        /// Get Server info from its login token
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="loginToken">The login token to query. The API key owner must have own the server for this to work</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A condensed server account info response</returns>
        public static SteamGameServerCondensedAccountInfo GetServerLoginTokenInfo<T>(this T client, string loginToken, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerLoginTokenInfoRequest(loginToken);
            return client.Perform<SteamGameServerLoginTokenInfoResponse>(request, token)?.CondensedAccountInfo;
        }

        /// <summary>
        /// Get Server info from its login token
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="loginToken">The login token to query. The API key owner must have own the server for this to work</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A condensed server account info response</returns>
        public static async Task<SteamGameServerCondensedAccountInfo> GetServerLoginTokenInfoAsync<T>(this T client, string loginToken, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerLoginTokenInfoRequest(loginToken);
            return (await client.PerformAsync<SteamGameServerLoginTokenInfoResponse>(request, token).ConfigureAwait(false))?.CondensedAccountInfo;
        }
    }
}
