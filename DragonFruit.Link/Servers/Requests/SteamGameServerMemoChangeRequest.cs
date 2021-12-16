// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Net;
using DragonFruit.Data;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerMemoChangeRequest : SteamApiRequest, IForSteamUser
    {
        protected override Methods Method => Methods.Post;
        protected override BodyType BodyType => BodyType.Encoded;

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
