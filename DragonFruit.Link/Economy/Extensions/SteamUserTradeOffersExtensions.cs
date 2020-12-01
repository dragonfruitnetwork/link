// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Economy.Responses;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeOffersExtensions
    {
        /// <summary>
        /// Get a collection of all outstanding trades (sent or received) to this account. Includes Item descriptions
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <returns>A collection of sent and received offers, with their item descriptions</returns>
        public static SteamUserTradeOffersContainer GetTrades(this SteamApiClient client)
        {
            var request = new SteamUserTradeOffersRequest();
            return client.Perform<SteamUserTradeOffersResponse>(request)?.Offers;
        }
    }
}
