// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Link.News.Objects;
using DragonFruit.Link.News.Requests;
using DragonFruit.Link.News.Responses;
using System.Threading;

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
        /// <returns>A <see cref="SteamNewsContainer"/> containing the 30 most recent <see cref="SteamNewsItem"/>s</returns>
        public static SteamNewsContainer GetAppNews(this ApiClient client, uint appId) =>
            GetAppNews(client, appId, 30);

        /// <summary>
        /// Creates and performs a <see cref="SteamNewsRequest"/> using the provided options
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The AppId to get the news for</param>
        /// <param name="max">The max number of news entries to return</param>
        /// <returns>A <see cref="SteamNewsContainer"/> containing up-to the <see cref="max"/> number of <see cref="SteamNewsItem"/>s</returns>
        public static SteamNewsContainer GetAppNews(this ApiClient client, uint appId, uint max)
        {
            var request = new SteamNewsRequest(appId, max);
            return GetAppNews(client, request);
        }

        /// <summary>
        /// Creates and performs a <see cref="SteamNewsRequest"/> using the provided options
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The AppId to get the news for</param>
        /// <param name="max">The max number of news entries to return</param>
        /// <param name="descriptionLength">The max chars the body should contain</param>
        /// <returns>A <see cref="SteamNewsContainer"/> containing up-to the <see cref="max"/> number of <see cref="SteamNewsItem"/> with each content entry being no more than <see cref="descriptionLength"/> chars</returns>
        public static SteamNewsContainer GetAppNews(this ApiClient client, uint appId, uint max, uint descriptionLength)
        {
            var request = new SteamNewsRequest(appId, max, descriptionLength);
            return GetAppNews(client, request);
        }

        /// <summary>
        /// Performs a <see cref="SteamNewsRequest"/> and deserialises it to the underlying <see cref="SteamNewsContainer"/>
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="request">The <see cref="SteamNewsRequest"/> to perform</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>A <see cref="SteamNewsContainer"/> containing the <see cref="SteamNewsItem"/>s</returns>
        private static SteamNewsContainer GetAppNews(this ApiClient client, SteamNewsRequest request, CancellationToken token = default)
        {
            return client.Perform<SteamNewsResponse>(request, token).Container;
        }
    }
}