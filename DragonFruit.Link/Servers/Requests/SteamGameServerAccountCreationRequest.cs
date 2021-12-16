// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerAccountCreationRequest : SteamApiRequest, IForSteamApp
    {
        protected override Methods Method => Methods.Post;
        protected override BodyType BodyType => BodyType.Encoded;

        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "CreateAccount";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerAccountCreationRequest(uint appId, string memo)
        {
            AppId = appId;
            Memo = memo;
        }

        [FormParameter("appid")]
        public uint AppId { get; set; }

        [FormParameter("memo")]
        public string Memo { get; set; }
    }
}
