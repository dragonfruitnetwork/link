// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserProfileResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserProfileContainer? Container { get; set; }
    }

    public class SteamUserProfileContainer
    {
        [JsonProperty("players")]
        public IEnumerable<SteamUserProfile>? Profiles { get; set; }
    }
}
