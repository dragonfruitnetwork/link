// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Economy.Requests;
using DragonFruit.Link.Exceptions;

namespace DragonFruit.Link.Economy.Extensions
{
    public static class SteamUserTradeDeclineExtensions
    {
        /// <summary>
        /// Cancel a trade offer the API Key owner has made
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="offerId">The id of the offer to cancel</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static void CancelTrade<T>(this T client, ulong offerId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            PerformRequestValidateCode(client, new SteamUserTradeCancelRequest(offerId));
        }

        /// <summary>
        /// Decline a trade offer sent to the API Key owner
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="offerId">The id of the offer to decline</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static void DeclineTrade<T>(this T client, ulong offerId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            PerformRequestValidateCode(client, new SteamUserTradeDeclineRequest(offerId));
        }

        /// <summary>
        /// Cancel a trade offer the API Key owner has made
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="offerId">The id of the offer to cancel</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static Task CancelTradeAsync<T>(this T client, ulong offerId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            return PerformRequestValidateCodeAsync(client, new SteamUserTradeCancelRequest(offerId));
        }

        /// <summary>
        /// Decline a trade offer sent to the API Key owner
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="offerId">The id of the offer to decline</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static Task DeclineTradeAsync<T>(this T client, ulong offerId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            return PerformRequestValidateCodeAsync(client, new SteamUserTradeDeclineRequest(offerId));
        }

        private static void PerformRequestValidateCode(ApiClient client, ApiRequest request)
        {
            using var response = client.Perform(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new SteamRequestFailedException();
            }
        }

        private static async Task PerformRequestValidateCodeAsync(ApiClient client, ApiRequest request)
        {
            using var response = await client.PerformAsync(request).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new SteamRequestFailedException();
            }
        }
    }
}
