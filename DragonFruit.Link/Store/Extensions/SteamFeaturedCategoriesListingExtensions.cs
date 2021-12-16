// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Exceptions;
using DragonFruit.Link.Store.Objects;
using DragonFruit.Link.Store.Requests;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Store.Extensions
{
    public static class SteamFeaturedCategoriesListingExtensions
    {
        /// <summary>
        /// Get the items currently listed under the featured categories
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamFeaturedCategory"/></returns>
        public static IEnumerable<SteamFeaturedCategory> GetFeaturedCategories(this ApiClient client, CancellationToken token = default)
        {
            var request = new SteamFeaturedCategoriesListingRequest();
            var response = client.Perform<JObject>(request, token);

            return ProcessRawResult(response ?? throw new SteamRequestFailedException());
        }

        /// <summary>
        /// Get the items currently listed under the featured categories
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamFeaturedCategory"/></returns>
        public static async Task<IEnumerable<SteamFeaturedCategory>> GetFeaturedCategoriesAsync(this ApiClient client, CancellationToken token = default)
        {
            var request = new SteamFeaturedCategoriesListingRequest();
            var response = await client.PerformAsync<JObject>(request, token).ConfigureAwait(false);

            return ProcessRawResult(response ?? throw new SteamRequestFailedException());
        }

        private static IEnumerable<SteamFeaturedCategory> ProcessRawResult(JObject response)
        {
            response.Remove("status"); // the status value will screw up the loop below

            foreach (var node in response)
            {
                var v = node.Value;

                if (v is not null)
                {
                    yield return v.ToObject<SteamFeaturedCategory>();
                }
            }
        }
    }
}
