// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Store
{
    /// <summary>
    /// Special Wrapper for API Requests to the Steam Store (unlike the others that are routed to Steamworks)
    /// </summary>
    public abstract class SteamStoreApiRequest : SteamApiRequest
    {
        public override string Interface => string.Empty;
        public override string InterfaceMethod => string.Empty;

        public override int MethodVersion => 0;

        public override bool RequireApiKey => false;

        public abstract string RequestPath { get; }

        public override string PathOverride => $"https://store.steampowered.com/api/{RequestPath}/";

        [JsonProperty("l")]
        public string LanguageName { get; set; }

        [JsonProperty("cc")]
        public string CountryCode { get; set; }
    }
}
