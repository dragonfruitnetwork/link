// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserFriendsExtensions
    {
        /// <summary>
        /// Gets the user's friends, as a list
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="SteamUserFriend"/> objects</returns>
        /// <remarks>This will cause an exception if the user's friend list is set to something other than "Public"</remarks>
        public static IEnumerable<SteamUserFriend> GetUserFriends(this SteamApiClient client, ulong steamId)
        {
            var request = new SteamUserFriendsRequest(steamId);
            return client.Perform<SteamUserFriendsResponse>(request).Container.Friends;
        }
    }
}
