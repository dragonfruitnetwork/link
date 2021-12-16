﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Library.Objects;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamAppVersionCheckExtensions
    {
        /// <summary>
        /// Check a Steam apps' current version
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get achievements for</param>
        /// <param name="appVersion">The App Version to check against</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamAppVersionInfo"/> containing the latest version info and whether the version provided is the latest</returns>
        public static SteamAppVersionInfo CheckAppVersion(this ApiClient client, uint appId, uint appVersion, CancellationToken token = default)
        {
            var request = new SteamAppVersionCheckRequest(appId, appVersion);
            return client.Perform<SteamAppVersionCheckResponse>(request, token)?.VersionInfo;
        }

        /// <summary>
        /// Check a Steam apps' current version
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get achievements for</param>
        /// <param name="appVersion">The App Version to check against</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamAppVersionInfo"/> containing the latest version info and whether the version provided is the latest</returns>
        public static async Task<SteamAppVersionInfo> CheckAppVersionAsync(this ApiClient client, uint appId, uint appVersion, CancellationToken token = default)
        {
            var request = new SteamAppVersionCheckRequest(appId, appVersion);
            return (await client.PerformAsync<SteamAppVersionCheckResponse>(request, token).ConfigureAwait(false))?.VersionInfo;
        }
    }
}
