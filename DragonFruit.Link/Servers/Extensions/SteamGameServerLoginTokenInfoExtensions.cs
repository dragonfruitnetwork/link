// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        /// <returns>A condensed server account info response</returns>
        public static SteamGameServerCondensedAccountInfo GetServerLoginTokenInfo(this SteamApiClient client, string loginToken)
        {
            var request = new SteamGameServerLoginTokenInfoRequest(loginToken);
            return client.Perform<SteamGameServerLoginTokenInfoResponse>(request)?.CondensedAccountInfo;
        }
    }
}
