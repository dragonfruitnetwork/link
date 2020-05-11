// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserFriendsResponse : ISteamApiResponse
    {
        [JsonProperty("friendslist")]
        public SteamUserFriendsContainer Container { get; set; }
    }

    public class SteamUserFriendsContainer
    {
        [JsonProperty("friends")]
        public IEnumerable<SteamUserFriend> Friends { get; set; }
    }
}
