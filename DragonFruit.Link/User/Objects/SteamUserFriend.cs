// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using DragonFruit.Link.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Objects
{
    public class SteamUserFriend
    {
        /// <summary>
        /// The SteamID64 of the associate
        /// </summary>
        [JsonProperty("steamid")]
        public ulong Id { get; set; }

        /// <summary>
        /// Their relation to the user
        /// </summary>
        [JsonProperty("relationship")]
        public SteamUserRelation Relation { get; set; }

        /// <summary>
        /// The epoch they became associated with each other
        /// </summary>
        [JsonProperty("friend_since")]
        public ulong FriendsSinceEpoch { get; set; }

        /// <summary>
        /// The date they became associated with each other (from <see cref="FriendsSinceEpoch"/>)
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset FriendsSince => DateTimeOffset.UnixEpoch.AddSeconds(FriendsSinceEpoch);
    }
}
