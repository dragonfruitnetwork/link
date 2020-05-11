// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
