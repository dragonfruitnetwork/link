// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserBadgesResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserBadgesInfo? BadgeInfo { get; set; }
    }

    public class SteamUserBadgesInfo
    {
        /// <summary>
        /// User's current XP
        /// </summary>
        [JsonProperty("player_xp")]
        public int CurrentXP { get; set; }

        /// <summary>
        /// User's Current Level from badges
        /// </summary>
        [JsonProperty("player_level")]
        public int CurrentLevel { get; set; }

        /// <summary>
        /// How much XP is needed to increase the <see cref="CurrentLevel"/>
        /// </summary>
        [JsonProperty("player_xp_needed_to_level_up")]
        public int XPRemaining { get; set; }

        /// <summary>
        /// Minimum XP to reach <see cref="CurrentLevel"/>
        /// </summary>
        [JsonProperty("player_xp_needed_current_level")]
        public int CurrentLevelXP { get; set; }

        /// <summary>
        /// <see cref="IEnumerable{T}"/> of the user's badges
        /// </summary>
        [JsonProperty("badges")]
        public IEnumerable<SteamUserBadge> Badges { get; set; }
    }
}
