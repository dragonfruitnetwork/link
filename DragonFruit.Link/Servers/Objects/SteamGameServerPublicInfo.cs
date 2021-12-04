// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Servers.Objects
{
    public class SteamGameServerPublicInfo
    {
        [JsonProperty("steamid")]
        public ulong Id { get; set; }

        [JsonProperty("appid")]
        public uint AppId { get; set; }
    }
}
