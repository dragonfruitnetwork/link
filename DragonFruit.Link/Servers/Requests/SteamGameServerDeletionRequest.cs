﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerDeletionRequest : SteamApiRequest, IForSteamUser
    {
        protected override Methods Method => Methods.Post;
        protected override BodyType BodyType => BodyType.Encoded;

        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "DeleteAccount";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerDeletionRequest(ulong serverSteamId)
        {
            Id = serverSteamId;
        }

        [FormParameter("steamid")]
        public ulong Id { get; set; }
    }
}
