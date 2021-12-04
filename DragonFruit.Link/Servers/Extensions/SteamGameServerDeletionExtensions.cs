// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Requests;
using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Common.Data;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerDeletionExtensions
    {
        /// <summary>
        /// Delete a game server from Steam
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="serverId">The Steam Id of the game server</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static void DeleteGameServer<T>(this T client, ulong serverId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerDeletionRequest(serverId);
            var response = client.Perform(request, token);

            response.Dispose();
        }

        /// <summary>
        /// Delete a game server from Steam
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="serverId">The Steam Id of the game server</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        public static async Task DeleteGameServerAsync<T>(this T client, ulong serverId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamGameServerDeletionRequest(serverId);
            var response = await client.PerformAsync(request, token);

            response.Dispose();
        }
    }
}
