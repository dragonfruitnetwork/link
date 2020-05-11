// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;

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
