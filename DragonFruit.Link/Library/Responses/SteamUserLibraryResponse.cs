// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Library.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Responses
{
    public class SteamUserLibraryResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserLibraryContainer Library { get; set; }
    }

    public class SteamUserLibraryContainer
    {
        [JsonProperty("game_count")]
        public uint Total { get; set; }

        [JsonProperty("games")]
        public IEnumerable<SteamApp> Apps { get; set; }
    }
}
