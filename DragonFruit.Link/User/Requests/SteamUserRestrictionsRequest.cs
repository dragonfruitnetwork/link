// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserRestrictionsRequest : SteamCompiledSteamIdRequest
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
