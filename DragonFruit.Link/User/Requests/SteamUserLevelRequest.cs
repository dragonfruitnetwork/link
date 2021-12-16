// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserLevelRequest : SteamApiRequest, IForSteamUser
    {
        public override string Interface => "IPlayerService";
        public override string InterfaceMethod => "GetSteamLevel";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserLevelRequest(ulong steamId)
        {
            Id = steamId;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }
    }
}
