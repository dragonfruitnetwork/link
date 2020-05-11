// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.Servers.Requests;

namespace DragonFruit.Link.Servers.Extensions
{
    public static class SteamGameServerDeletionExtensions
    {
        /// <summary>
        /// Delete a game server from Steam
        /// </summary>
        /// <param name="client">The <see cref="SteamApiRequest"/> to use</param>
        /// <param name="serverId">The Steam Id of the game server</param>
        public static void DeleteGameServer(this SteamApiClient client, ulong serverId)
        {
            var request = new SteamGameServerDeletionRequest(serverId);
            var response = client.Perform(request);

            response.Dispose();
        }
    }
}
