// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
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
        /// <returns>Every single Steam App published as a <see cref="SteamBasicSteamApp"/></returns>
        public static IEnumerable<SteamBasicSteamApp> GetAllAppNameAndIds(this ApiClient client)
        {
            var request = new SteamAppsListingRequest();
            return client.Perform<SteamAppsListingResponse>(request).Listing.Apps;
        }
    }
}
