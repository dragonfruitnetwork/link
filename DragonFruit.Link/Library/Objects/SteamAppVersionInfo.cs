// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Library.Objects
{
    public class SteamAppVersionInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("up_to_date")]
        public bool IsLatestVersion { get; set; }

        [JsonProperty("version_is_listable")]
        public bool VersionListed { get; set; }

        [JsonProperty("required_version")]
        public uint? RequiredVersion { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
