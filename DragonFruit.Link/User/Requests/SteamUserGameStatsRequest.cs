// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data.Parameters;

#nullable enable

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserGameStatsRequest : SteamApiRequest, IForSteamUser, IForSteamApp, IHasOptionalLanguage
    {
        public override string Interface => "ISteamUserStats";
        public override string InterfaceMethod => "GetUserStatsForGame";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => true;

        public SteamUserGameStatsRequest(ulong steamId, uint appId)
        {
            Id = steamId;
            AppId = appId;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("l")]
        public string LanguageCode { get; set; }
    }
}
