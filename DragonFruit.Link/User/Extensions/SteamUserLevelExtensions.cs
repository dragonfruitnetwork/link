// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.User.Requests;
using DragonFruit.Link.User.Responses;

namespace DragonFruit.Link.User.Extensions
{
    public static class SteamUserLevelExtensions
    {
        /// <summary>
        /// Get a User's Steam Level
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="steamId">The user's SteamID64</param>
        /// <returns>An unsigned int32 representing the user's level</returns>
        public static uint? GetUserLevel(this SteamApiClient client, ulong steamId)
        {
            var request = new SteamUserLevelRequest(steamId);
            return client.Perform<SteamUserLevelResponse>(request)?.UserLevelInfo.Level;
        }
    }
}
