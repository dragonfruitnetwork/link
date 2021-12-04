// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
