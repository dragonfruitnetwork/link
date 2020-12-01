// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;

#nullable enable

namespace DragonFruit.Link.Game.Requests
{
    public class SteamGameSchemaRequest : SteamApiRequest, IForSteamApp
    {
        public override string Interface => "ISteamUserStats";
        public override string InterfaceMethod => "GetSchemaForGame";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => true;

        public SteamGameSchemaRequest(uint appId)
        {
            AppId = appId;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("l")]
        public string LanguageCode { get; set; }
    }
}
