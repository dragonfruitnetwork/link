// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Link.News.Objects;
using DragonFruit.Link.News.Requests;
using DragonFruit.Link.News.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace DragonFruit.Link.News.Extensions
{
    /// <summary>
    /// Static Extensions for <see cref="SteamNewsRequest"/> building and performing
    /// </summary>
    public static class SteamNewsExtensions
    {
        /// <summary>
        /// Creates and performs a <see cref="SteamNewsRequest"/> using the provided options
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The AppId to get the news for</param>
        /// <param name="max">The max number of news entries to return</param>
        /// <param name="descriptionLength">The max chars the body should contain</param>
        /// <param name="token">Optional cancellation token to stop the request</param>
        /// <returns>A <see cref="SteamNewsContainer"/> containing up-to the <see cref="max"/> number of <see cref="SteamNewsItem"/> with each content entry being no more than <see cref="descriptionLength"/> chars</returns>
        public static SteamNewsContainer GetAppNews(this ApiClient client, uint appId, uint max = 30, uint? descriptionLength = null, CancellationToken token = default)
        {
            var request = new SteamNewsRequest(appId, max, descriptionLength);
            return client.Perform<SteamNewsResponse>(request, token)?.Container;
        }

        /// <summary>
        /// Creates and performs a <see cref="SteamNewsRequest"/> using the provided options
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The AppId to get the news for</param>
        /// <param name="max">The max number of news entries to return</param>
        /// <param name="descriptionLength">The max chars the body should contain</param>
        /// <param name="token">Optional cancellation token to stop the request</param>
        /// <returns>A <see cref="SteamNewsContainer"/> containing up-to the <see cref="max"/> number of <see cref="SteamNewsItem"/> with each content entry being no more than <see cref="descriptionLength"/> chars</returns>
        public static async Task<SteamNewsContainer> GetAppNewsAsync(this ApiClient client, uint appId, uint max = 30, uint? descriptionLength = null, CancellationToken token = default)
        {
            var request = new SteamNewsRequest(appId, max, descriptionLength);
            return (await client.PerformAsync<SteamNewsResponse>(request, token).ConfigureAwait(false))?.Container;
        }
    }
}
