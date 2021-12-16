// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Exceptions;
using DragonFruit.Link.User.Objects;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserProfileExtensions
    {
        /// <summary>
        /// Resolves a profile url to a <see cref="SteamUserProfile"/>
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamUrl">The user's steam link, with or without the domain</param>
        /// <returns>The user's <see cref="SteamUserProfile"/>, providing the url was valid</returns>
        public static SteamUserProfile GetUserProfile<T>(this T client, string steamUrl) where T : ApiClient, ISteamApiClient
        {
            ulong? steamId = null;

            if (steamUrl.Contains("id"))
            {
                steamId = client.ResolveVanityUrl(GetUserVanityName(steamUrl));
            }
            else if (steamUrl.Contains("profiles"))
            {
                steamId = GetUserId(steamUrl);
            }

            // todo custom exception
            return GetUserProfile(client, steamId ?? throw new SteamRequestFailedException());
        }

        /// <summary>
        /// Resolves a profile url to a <see cref="SteamUserProfile"/>
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamUrl">The user's steam link, with or without the domain</param>
        /// <returns>The user's <see cref="SteamUserProfile"/>, providing the url was valid</returns>
        public static async Task<SteamUserProfile> GetUserProfileAsync<T>(this T client, string steamUrl) where T : ApiClient, ISteamApiClient
        {
            ulong? steamId = null;

            if (steamUrl.Contains("id"))
            {
                steamId = await client.ResolveVanityUrlAsync(GetUserVanityName(steamUrl)).ConfigureAwait(false);
            }
            else if (steamUrl.Contains("profiles"))
            {
                steamId = GetUserId(steamUrl);
            }

            // todo custom exception
            return await GetUserProfileAsync(client, steamId ?? throw new SteamRequestFailedException()).ConfigureAwait(false);
        }

        /// <summary>
        /// Get profile info about a user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The user's <see cref="SteamUserProfile"/></returns>
        public static SteamUserProfile GetUserProfile<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserProfileRequest(steamId);
            return client.Perform<SteamUserProfileResponse>(request, token)?.Container?.Profiles.Single();
        }

        /// <summary>
        /// Get profile info about a user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The user's <see cref="SteamUserProfile"/></returns>
        public static async Task<SteamUserProfile> GetUserProfileAsync<T>(this T client, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserProfileRequest(steamId);
            return (await client.PerformAsync<SteamUserProfileResponse>(request, token).ConfigureAwait(false))?.Container?.Profiles.Single();
        }

        /// <summary>
        /// Get profile info about multiple users
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamIds"><see cref="IEnumerable{T}"/> of user SteamID64s</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamUserProfile"/></returns>
        public static IEnumerable<SteamUserProfile> GetUserProfiles<T>(this T client, IEnumerable<ulong> steamIds, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserProfileRequest(steamIds);
            return client.Perform<SteamUserProfileResponse>(request, token)?.Container?.Profiles;
        }

        /// <summary>
        /// Get profile info about multiple users
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamIds"><see cref="IEnumerable{T}"/> of user SteamID64s</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamUserProfile"/></returns>
        public static async Task<IEnumerable<SteamUserProfile>> GetUserProfilesAsync<T>(this T client, IEnumerable<ulong> steamIds, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamUserProfileRequest(steamIds);
            return (await client.PerformAsync<SteamUserProfileResponse>(request, token).ConfigureAwait(false))?.Container?.Profiles;
        }

        private static string GetUserVanityName(string url) => url.TrimEnd('/').Split('/').Last();

        private static ulong? GetUserId(string url)
        {
            var userId = url.TrimEnd('/').Split('/').Last();
            return ulong.TryParse(userId, out var parsedId) ? parsedId : null;
        }
    }
}
