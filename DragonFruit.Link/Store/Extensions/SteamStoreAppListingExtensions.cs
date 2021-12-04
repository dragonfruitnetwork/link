﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Link.Exceptions;
using DragonFruit.Link.Store.Objects;
using DragonFruit.Link.Store.Requests;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DragonFruit.Link.Store.Extensions
{
    public static class SteamStoreAppListingExtensions
    {
        /// <summary>
        /// Get the store listing info for an app/game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="appId">The App Id to get the listing for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamStoreAppListing"/></returns>
        public static SteamStoreAppListing GetStoreListing(this ApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamStoreAppListingRequest(appId);
            var response = client.Perform<JObject>(request, token);

            return ProcessRawResult(response, appId.ToString());
        }

        /// <summary>
        /// Get the store listing info for an app/game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="appId">The App Id to get the listing for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamStoreAppListing"/></returns>
        public static async Task<SteamStoreAppListing> GetStoreListingAsync(this ApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamStoreAppListingRequest(appId);
            var response = await client.PerformAsync<JObject>(request, token).ConfigureAwait(false);

            return ProcessRawResult(response, appId.ToString());
        }

        private static SteamStoreAppListing ProcessRawResult(JObject response, string appId)
        {
            if (response == null)
            {
                // todo custom exception
                throw new SteamRequestFailedException();
            }

            return response[appId]!["data"]!.ToObject<SteamStoreAppListing>();
        }
    }
}
