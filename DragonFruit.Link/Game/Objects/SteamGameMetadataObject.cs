// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Game.Objects
{
    public class SteamGameMetadataObject
    {
        [JsonProperty("name")]
        public string Id { get; set; }

        [JsonProperty("defaultvalue")]
        public double Default { get; set; }

        [JsonProperty("displayName")]
        public string Name { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icongray")]
        public string GrayIcon { get; set; }
    }
}
