// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Library.Objects
{
    public class SteamApp
    {
        [JsonProperty("appid")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playtime_2weeks")]
        public ulong MinutesPlayedRecently { get; set; }

        [JsonProperty("playtime_forever")]
        public ulong MinutesPlayed { get; set; }

        [JsonProperty("playtime_windows_forever")]
        public ulong MinutesPlayedWindows { get; set; }

        [JsonProperty("playtime_linux_forever")]
        public ulong MinutesPlayedLinux { get; set; }

        [JsonProperty("playtime_mac_forever")]
        public ulong MinutesPlayedMac { get; set; }

        #region Minutes Played -> TimeSpan

        [JsonIgnore]
        public TimeSpan TimePlayedRecently => TimeSpan.FromMinutes(MinutesPlayedRecently);

        [JsonIgnore]
        public TimeSpan TimePlayed => TimeSpan.FromMinutes(MinutesPlayed);

        [JsonIgnore]
        public TimeSpan TimePlayedWindows => TimeSpan.FromMinutes(MinutesPlayedWindows);

        [JsonIgnore]
        public TimeSpan TimePlayedLinux => TimeSpan.FromMinutes(MinutesPlayedLinux);

        [JsonIgnore]
        public TimeSpan TimePlayedMac => TimeSpan.FromMinutes(MinutesPlayedMac);

        #endregion

        [JsonProperty("img_icon_url")]
        public string IconId { get; set; }

        [JsonProperty("img_logo_url")]
        public string LogoId { get; set; }

        #region Image Uri Concat

        [JsonIgnore]
        public string IconUrl => $"https://media.steampowered.com/steamcommunity/public/images/apps/{Id}/{IconId}.jpg";

        [JsonIgnore]
        public string LogoUrl => $"https://media.steampowered.com/steamcommunity/public/images/apps/{Id}/{LogoId}.jpg";

        #endregion

        [JsonProperty("has_community_visible_stats")]
        public bool HasStats { get; set; }
    }
}
