// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserRestriction
    {
        /// <summary>
        /// The SteamID64 of the user being checked
        /// </summary>
        [JsonProperty("SteamId")]
        public ulong Id { get; set; }

        /// <summary>
        /// Whether the user has been banned from interacting with community features (i.e. posting on forms and publishing guides)
        /// </summary>
        [JsonProperty("CommunityBanned")]
        public bool CommunityBanned { get; set; }

        /// <summary>
        /// Whether the user has been banned by Valve Anti-Cheat
        /// </summary>
        [JsonProperty("VACBanned")]
        public bool VacBanned { get; set; }

        /// <summary>
        /// How many times they have been banned by Valve Anti-Cheat
        /// </summary>
        [JsonProperty("NumberOfVACBans")]
        public uint VacBans { get; set; }

        /// <summary>
        /// How many days since the last ban was issued (of any type)
        /// </summary>
        [JsonProperty("DaysSinceLastBan")]
        public uint DaysSinceLastBan { get; set; }

        /// <summary>
        /// How many bans have been issued against this account by game developers
        /// </summary>
        [JsonProperty("NumberOfGameBans")]
        public uint GameBans { get; set; }

        /// <summary>
        /// Whether the account is able to trade/sell on the community market
        /// </summary>
        [JsonProperty("EconomyBan")]
        public string EconomyBan { get; set; }
    }
}
