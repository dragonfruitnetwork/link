// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Objects
{
    public class SteamSharedGameLenderInfo
    {
        /// <summary>
        /// Lender's SteamID64
        /// </summary>
        [JsonProperty("lender_steamid")]
        public ulong LenderSteamId { get; set; }
    }
}
