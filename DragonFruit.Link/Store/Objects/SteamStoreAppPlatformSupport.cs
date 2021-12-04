// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppPlatformSupport
    {
        [JsonProperty("windows")]
        public bool IsOnWindows { get; set; }

        [JsonProperty("linux")]
        public bool IsOnLinux { get; set; }

        [JsonProperty("mac")]
        public bool IsOnMac { get; set; }
    }
}
