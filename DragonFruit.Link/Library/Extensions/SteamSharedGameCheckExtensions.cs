// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Threading;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Link.Library.Requests;
using DragonFruit.Link.Library.Responses;

namespace DragonFruit.Link.Library.Extensions
{
    public static class SteamSharedGameCheckExtensions
    {
        /// <summary>
        /// Get the Steam Id of the owner of a shared/borrowed game, if it is being actively shared with the user (i.e. they're playing it).
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to check</param>
        /// <param name="steamId">The SteamID64 of the User "borrowing" the game</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The Game Owners' SteamID64</returns>
        /// <remarks>The user must be currently playing the game for this to return a valid result. If 0 is returned the user either owns the game or they aren't currently playing it.</remarks>
        public static ulong? GetSharedGameOwner<T>(this T client, uint appId, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamSharedGameCheckRequest(steamId, appId);
            return client.Perform<SteamSharedGameCheckResponse>(request, token)?.LenderInfo.LenderSteamId;
        }

        /// <summary>
        /// Get the Steam Id of the owner of a shared/borrowed game, if it is being actively shared with the user (i.e. they're playing it).
        /// </summary>
        /// <param name="client">The <see cref="SteamApiClient"/> to use</param>
        /// <param name="appId">The App Id to check</param>
        /// <param name="steamId">The SteamID64 of the User "borrowing" the game</param>
        /// <param name="token">The <see cref="CancellationToken"/> to pass when performing the request</param>
        /// <returns>The Game Owners' SteamID64</returns>
        /// <remarks>The user must be currently playing the game for this to return a valid result. If 0 is returned the user either owns the game or they aren't currently playing it.</remarks>
        public static async Task<ulong?> GetSharedGameOwnerAsync<T>(this T client, uint appId, ulong steamId, CancellationToken token = default) where T : ApiClient, ISteamApiClient
        {
            var request = new SteamSharedGameCheckRequest(steamId, appId);
            return (await client.PerformAsync<SteamSharedGameCheckResponse>(request, token).ConfigureAwait(false))?.LenderInfo.LenderSteamId;
        }
    }
}
