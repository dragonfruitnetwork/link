// DragonFruit Link API Copyright 2021 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

namespace DragonFruit.Link
{
    /// <summary>
    /// Abstraction of the properties required for authenticated <see cref="SteamApiRequest"/>s to work
    /// </summary>
    public interface ISteamApiClient
    {
        string ApiKey { get; }
    }
}
