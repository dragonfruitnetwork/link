// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Net;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerMemoChangeRequest : SteamApiRequest, IForSteamUser
    {
        public override Methods Method => Methods.Post;
        public override DataTypes DataType => DataTypes.Encoded;

        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "SetMemo";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerMemoChangeRequest(ulong serverSteamId, string memo)
        {
            Id = serverSteamId;
            Memo = memo;
        }

        [FormParameter("steamid")]
        public ulong Id { get; set; }

        public string Memo { get; set; }

        [FormParameter("memo")]
        internal string EncodedMemo => WebUtility.HtmlEncode(Memo);
    }
}
