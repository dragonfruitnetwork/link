// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserLink
    {
        [JsonProperty("steamid")]
        public ulong Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
