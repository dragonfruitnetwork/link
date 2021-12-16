// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;
using DragonFruit.Link.Enums;

#nullable enable

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserFriendsRequest : SteamApiRequest, IForSteamUser
    {
        public override string Interface => "ISteamUser";
        public override string InterfaceMethod => "GetFriendList";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserFriendsRequest(ulong steamId)
            : this(steamId, SteamUserRelation.Friend)
        {
        }

        public SteamUserFriendsRequest(ulong steamId, SteamUserRelation relation)
        {
            Id = steamId;
            Relation = relation;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }

        [QueryParameter("relationship")]
        private string UserRelationString => Relation.ToString()?.ToLowerInvariant();

        public SteamUserRelation? Relation { get; set; }
    }
}
