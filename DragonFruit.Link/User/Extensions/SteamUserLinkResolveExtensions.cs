// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserLinkResolveExtensions
    {
        /// <summary>
        /// Converts a user's vanity url segment to their SteamID64
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="linkSegment">The segment of the vanity url the user chooses (if the overall link is https://steamcommunity.com/id/papa_curry to get their id pass "papa_curry")</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The users SteamID64 (or null if the link was not found)</returns>
        public static ulong? ResolveVanityUrl<T>(this T client, string linkSegment, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserLinkResolveRequest(linkSegment);
            return client.Perform<SteamUserLinkResolveResponse>(request, token)?.LinkInfo?.Id;
        }

        /// <summary>
        /// Converts a user's vanity url segment to their SteamID64
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="linkSegment">The segment of the vanity url the user chooses (if the overall link is https://steamcommunity.com/id/papa_curry to get their id pass "papa_curry")</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The users SteamID64 (or null if the link was not found)</returns>
        public static async Task<ulong?> ResolveVanityUrlAsync<T>(this T client, string linkSegment, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserLinkResolveRequest(linkSegment);
            return (await client.PerformAsync<SteamUserLinkResolveResponse>(request, token).ConfigureAwait(false))?.LinkInfo?.Id;
        }
    }
}
