// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Exceptions;

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserProfileRequest : SteamCompiledSteamIdRequest
    {
        public override string Interface => "ISteamUser";
        public override string InterfaceMethod => "GetPlayerSummaries";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => true;

        public SteamUserProfileRequest(ulong? user)
            : base(user ?? 0)
        {
            if (!user.HasValue)
            {
                throw new SteamBadRequestException();
            }
        }

        public SteamUserProfileRequest(ulong user)
            : base(user)
        {
        }

        public SteamUserProfileRequest(IEnumerable<ulong> users)
            : base(users)
        {
        }
    }
}
