// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
        public long FriendsSinceEpoch { get; set; }

        /// <summary>
        /// The date they became associated with each other (from <see cref="FriendsSinceEpoch"/>)
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset FriendsSince => DateTimeOffset.FromUnixTimeSeconds(FriendsSinceEpoch);
    }
}
