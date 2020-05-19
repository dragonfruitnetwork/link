// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Link.User.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.User.Responses
{
    public class SteamUserLevelResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserLevel? UserLevelInfo { get; set; }
    }
}
