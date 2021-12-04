// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserRestrictionsRequest : SteamCompiledIdRequest
    {
        public override string Interface => "ISteamUser";
        public override string InterfaceMethod => "GetPlayerBans";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserRestrictionsRequest(ulong user)
            : base(user)
        {
        }

        public SteamUserRestrictionsRequest(IEnumerable<ulong> users)
            : base(users)
        {
        }
    }
}
