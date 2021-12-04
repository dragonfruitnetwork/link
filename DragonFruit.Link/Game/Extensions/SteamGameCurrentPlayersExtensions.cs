﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Link.Game.Requests;
using DragonFruit.Link.Game.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace DragonFruit.Link.Game.Extensions
{
    public static class SteamGameCurrentPlayersExtensions
    {
        /// <summary>
        /// Get the number of people currently using an app/game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get the info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Unsigned integer with the total players</returns>
        public static uint? GetNumberOfCurrentPlayers(this ApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamGameCurrentPlayersRequest(appId);
            return client.Perform<SteamGameCurrentPlayersResponse>(request, token)?.TotalPlayerInfo?.CurrentPlayers;
        }

        /// <summary>
        /// Get the number of people currently using an app/game
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to get the info for</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>Unsigned integer with the total players</returns>
        public static async Task<uint?> GetNumberOfCurrentPlayersAsync(this ApiClient client, uint appId, CancellationToken token = default)
        {
            var request = new SteamGameCurrentPlayersRequest(appId);
            return (await client.PerformAsync<SteamGameCurrentPlayersResponse>(request, token).ConfigureAwait(false))?.TotalPlayerInfo?.CurrentPlayers;
        }
    }
}
