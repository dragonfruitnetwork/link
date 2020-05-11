// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
        public string? Message { get; set; }
    }
}
