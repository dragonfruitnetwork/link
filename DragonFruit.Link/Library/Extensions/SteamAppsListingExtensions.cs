// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.Library.Objects;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamAppsListingExtensions
    {
        /// <summary>
        /// <para>
        /// Gets a list of ALL the apps published on Steam. This includes EVERYTHING with no way to cap entries. You will be spending a LONG time waiting for this to succeed.
        /// </para>
        /// Use this with caution - it returns only the AppId and the Name. If you want to limit entries use <see cref="SteamStoreListingExtensions.GetStoreApps"/>
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Every single Steam App published as a <see cref="SteamBasicSteamApp"/></returns>
        public static IEnumerable<SteamBasicSteamApp> GetAllAppNameAndIds(this ApiClient client, CancellationToken token = default)
        {
            var request = new SteamAppsListingRequest();
            return client.Perform<SteamAppsListingResponse>(request, token)?.Listing.Apps;
        }

        /// <summary>
        /// <para>
        /// Gets a list of ALL the apps published on Steam. This includes EVERYTHING with no way to cap entries. You will be spending a LONG time waiting for this to succeed.
        /// </para>
        /// Use this with caution - it returns only the AppId and the Name. If you want to limit entries use <see cref="SteamStoreListingExtensions.GetStoreApps"/>
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Every single Steam App published as a <see cref="SteamBasicSteamApp"/></returns>
        public static async Task<IEnumerable<SteamBasicSteamApp>> GetAllAppNameAndIdsAsync(this ApiClient client, CancellationToken token = default)
        {
            var request = new SteamAppsListingRequest();
            return (await client.PerformAsync<SteamAppsListingResponse>(request, token).ConfigureAwait(false))?.Listing.Apps;
        }
    }
}
