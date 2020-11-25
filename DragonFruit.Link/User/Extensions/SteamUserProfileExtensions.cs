// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DragonFruit.Link.Exceptions;
using DragonFruit.Link.User.Objects;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserProfileExtensions
    {
        /// <summary>
        /// Resolves a user-customized profile url to a <see cref="SteamUserProfile"/>
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamUrl">The user's steam link, with or without the domain</param>
        /// <returns>The user's <see cref="SteamUserProfile"/>, providing the url was valid</returns>
        public static SteamUserProfile GetUserProfile(this SteamApiClient client, string steamUrl)
        {
            ulong? steamId = null;

            if (steamUrl.Contains("id"))
            {
                steamId = client.ResolveVanityUrl(steamUrl.TrimEnd('/').Split('/').Last());
            }
            else if (steamUrl.Contains("profiles"))
            {
                steamId = Convert.ToUInt64(steamUrl.TrimEnd('/').Split('/').Last());
            }

            //todo custom exception
            if (!steamId.HasValue)
                throw new SteamRequestFailedException();

            return GetUserProfile(client, steamId.Value);
        }

        /// <summary>
        /// Get profile info about a user
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The user's <see cref="SteamUserProfile"/></returns>
        public static SteamUserProfile GetUserProfile(this SteamApiClient client, ulong steamId, CancellationToken token = default)
        {
            var request = new SteamUserProfileRequest(steamId);
            return client.Perform<SteamUserProfileResponse>(request, token).Container.Profiles.Single();
        }

        /// <summary>
        /// Get profile info about multiple users
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="steamIds"><see cref="IEnumerable{T}"/> of user SteamID64s</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamUserProfile"/></returns>
        public static IEnumerable<SteamUserProfile> GetUserProfile(this SteamApiClient client, IEnumerable<ulong> steamIds, CancellationToken token = default)
        {
            var request = new SteamUserProfileRequest(steamIds);
            return client.Perform<SteamUserProfileResponse>(request, token).Container.Profiles;
        }
    }
}