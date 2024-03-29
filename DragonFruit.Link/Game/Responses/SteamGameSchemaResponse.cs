﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using DragonFruit.Link.Game.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Game.Responses
{
    public class SteamGameSchemaResponse : ISteamApiResponse
    {
        [JsonProperty("game")]
        public SteamGameSchemaContainer Schema { get; set; }
    }

    public class SteamGameSchemaContainer
    {
        [JsonProperty("gameName")]
        public string Name { get; set; }

        [JsonProperty("gameVersion")]
        public ulong Version { get; set; }

        [JsonProperty("availableGameStats")]
        public SteamGameSchemaDataContainer Data { get; set; }
    }

    public class SteamGameSchemaDataContainer
    {
        [JsonProperty("stats")]
        public IEnumerable<SteamGameMetadataObject> Stats { get; set; }

        [JsonProperty("achievements")]
        public IEnumerable<SteamGameMetadataObject> Achievements { get; set; }
    }
}
