// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Library.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Responses
{
    public class SteamUserLibraryResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserLibraryContainer? Library { get; set; }
    }

    public class SteamUserLibraryContainer
    {
        [JsonProperty("game_count")]
        public uint Total { get; set; }

        [JsonProperty("games")]
        public IEnumerable<SteamApp> Apps { get; set; }
    }
}
