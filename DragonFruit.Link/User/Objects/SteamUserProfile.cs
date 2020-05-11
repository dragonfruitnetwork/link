// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using DragonFruit.Link.Enums;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserProfile
    {
        /// <summary>
        /// User's SteamID64
        /// </summary>
        [JsonProperty("steamid")]
        public ulong Id { get; set; }

        /// <summary>
        /// Enum showing who has access to view the profile
        /// </summary>
        [JsonProperty("communityvisibilitystate")]
        public SteamProfileState ProfileVisibility { get; set; }

        /// <summary>
        /// Who the user allows to publish comments on their profile
        /// </summary>
        [JsonProperty("commentpermission")]
        public SteamCommentPermission CommentPermission { get; set; } = SteamCommentPermission.Friends;

        /// <summary>
        /// Their Real/IRL Name (optional)
        /// </summary>
        [JsonProperty("realname")]
        public string? RealName { get; set; }

        /// <summary>
        /// Their Avatar/Persona's Name
        /// </summary>
        [JsonProperty("personaname")]
        public string Name { get; set; }

        /// <summary>
        /// Steam URL to their profile
        /// </summary>
        [JsonProperty("profileurl")]
        public string Url { get; set; }

        /// <summary>
        /// UTC Epoch Last Logoff
        /// </summary>
        [JsonProperty("lastlogoff")]
        public ulong LastLogoffEpoch { get; set; }

        /// <summary>
        /// UTC Epoch Time the Account was created
        /// </summary>
        [JsonProperty("timecreated")]
        public ulong AccountCreatedEpoch { get; set; }

        #region Epoch -> DateTimeOffset

        [JsonIgnore]
        public DateTimeOffset LastLogoff => DateTimeOffset.UnixEpoch.AddSeconds(LastLogoffEpoch);

        [JsonIgnore]
        public DateTimeOffset AccountCreated => DateTimeOffset.UnixEpoch.AddSeconds(AccountCreatedEpoch);

        #endregion

        /// <summary>
        /// Id of their only/featured Clan/Group
        /// </summary>
        [JsonProperty("primaryclanid")]
        public ulong? PrimaryGroupId { get; set; }

        #region Location

        /// <summary>
        /// ISO-3166 2-Char Country Code
        /// </summary>
        [JsonProperty("loccountrycode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Internal Code for identifying a county/state inside the <see cref="CountryCode"/>
        /// </summary>
        [JsonProperty("locstatecode")]
        public string? CountryStateCode { get; set; }

        /// <summary>
        /// Numeric id of the user's city in the <see cref="CountryStateCode"/>
        /// </summary>
        [JsonProperty("loccityid")]
        public uint? CountryCityId { get; set; }

        #endregion

        /// <summary>
        /// Whether this user has completed the initial setup of their profile
        /// </summary>
        [JsonProperty("profilestate")]
        public bool ProfileSetup { get; set; }

        #region Profile Photos

        /// <summary>
        /// Small-size Profile Photo
        /// </summary>
        [JsonProperty("avatar")]
        public string Profile { get; set; }

        /// <summary>
        /// Medium-size Profile Photo
        /// </summary>
        [JsonProperty("avatarmedium")]
        public string ProfileMedium { get; set; }

        /// <summary>
        /// Largest/Highest Quality Profile Photo Steam Stores
        /// </summary>
        [JsonProperty("avatarfull")]
        public string ProfileLarge { get; set; }

        #endregion

        #region Current Activities

        /// <summary>
        /// The current state of the user, regarding being online
        /// </summary>
        [JsonProperty("personastate")]
        public SteamOnlineState OnlineState { get; set; }

        [JsonProperty("gameid")]
        public uint? CurrentGame { get; set; }

        [JsonProperty("gameextrainfo")]
        public string CurrentGameInfo { get; set; }

        #endregion
    }
}
