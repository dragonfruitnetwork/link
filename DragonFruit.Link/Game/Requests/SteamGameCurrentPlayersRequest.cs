// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Game.Requests
{
    public class SteamGameCurrentPlayersRequest : SteamApiRequest, IForSteamApp
    {
        public override string Interface => "ISteamUserStats";
        public override string InterfaceMethod => "GetNumberOfCurrentPlayers";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => false;

        public SteamGameCurrentPlayersRequest(uint appId)
        {
            AppId = appId;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }
    }
}
