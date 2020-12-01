// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Link.Game.Requests;
using DragonFruit.Link.Game.Responses;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGameCurrentPlayersExtensions
    {
        /// <summary>
        /// Get the number of people currently using an app/game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get the info for</param>
        /// <returns>Unsigned integer with the total players</returns>
        public static uint? GetNumberOfCurrentPlayers(this ApiClient client, uint appId)
        {
            var request = new SteamGameCurrentPlayersRequest(appId);
            return client.Perform<SteamGameCurrentPlayersResponse>(request)?.TotalPlayerInfo?.CurrentPlayers;
        }
    }
}
