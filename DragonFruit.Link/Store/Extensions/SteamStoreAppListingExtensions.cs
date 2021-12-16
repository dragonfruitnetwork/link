// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Exceptions;
using DragonFruit.Link.Store.Objects;
using DragonFruit.Link.Store.Requests;
using Newtonsoft.Json.Linq;

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
