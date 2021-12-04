// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Library.Requests
{
    public class SteamAppVersionCheckRequest : SteamApiRequest, IForSteamApp
    {
        public override string Interface => "ISteamApps";
        public override string InterfaceMethod => "UpToDateCheck";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => false;

        public SteamAppVersionCheckRequest(uint appId, uint currentVersion)
        {
            AppId = appId;
            CurrentVersion = currentVersion;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("version")]
        public uint CurrentVersion { get; set; }
    }
}
