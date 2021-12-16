// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Game.Requests
{
    public class SteamGlobalAchievementPercentageRequest : SteamApiRequest, IForSteamApp
    {
        public override string Interface => "ISteamUserStats";
        public override string InterfaceMethod => "GetGlobalAchievementPercentagesForApp";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => false;

        public SteamGlobalAchievementPercentageRequest(uint appId)
        {
            AppId = appId;
        }

        [QueryParameter("gameid")]
        public uint AppId { get; set; }
    }
}
