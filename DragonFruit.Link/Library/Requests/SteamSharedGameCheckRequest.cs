// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Library.Requests
{
    public class SteamSharedGameCheckRequest : SteamApiRequest, IForSteamUser
    {
        public override string Interface => "IPlayerService";
        public override string InterfaceMethod => "IsPlayingSharedGame";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamSharedGameCheckRequest(ulong steamId, uint currentGame)
        {
            Id = steamId;
            CurrentGame = currentGame;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }

        [QueryParameter("appid_playing")]
        public uint CurrentGame { get; set; }
    }
}
