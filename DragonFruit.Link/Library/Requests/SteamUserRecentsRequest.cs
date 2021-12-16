// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Library.Requests
{
    public class SteamUserRecentsRequest : SteamApiRequest, IForSteamUser
    {
        public override string Interface => "IPlayerService";
        public override string InterfaceMethod => "GetRecentlyPlayedGames";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserRecentsRequest(ulong steamId)
        {
            Id = steamId;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }

        [QueryParameter("count")]
        public ushort? Limit { get; set; }
    }
}
