// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Net.Http;
using System.Threading;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Exceptions;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeCancelExtensions
    {
        /// <summary>
        /// Cancel a trade offer the API Key owner has made
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="offerId">The id of the offer to cancel</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static void CancelTrade(this SteamApiClient client, ulong offerId, CancellationToken token = default)
        {
            var request = new SteamUserTradeCancelRequest(offerId);
            HttpResponseMessage result = null;

            try
            {
                result = client.Perform(request, token);

                if (!result.IsSuccessStatusCode)
                {
                    throw new SteamRequestFailedException();
                }
            }
            finally
            {
                result?.Dispose();
            }
        }
    }
}