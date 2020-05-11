// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using DragonFruit.Common.Data;
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
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamFeaturedCategory"/></returns>
        public static IEnumerable<SteamFeaturedCategory> GetFeaturedCategories(this ApiClient client)
        {
            var request = new SteamFeaturedCategoriesListingRequest();
            var response = client.Perform<JObject>(request);

            if (response == null)
            {
                //todo custom exception
                throw new Exception();
            }

            response.Remove("status"); // the response value will screw up the loop below

            foreach (var node in response)
            {
                yield return node.Value.ToObject<SteamFeaturedCategory>();
            }
        }
    }
}
