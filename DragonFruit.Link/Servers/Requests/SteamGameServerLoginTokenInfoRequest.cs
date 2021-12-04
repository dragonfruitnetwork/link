// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerLoginTokenInfoRequest : SteamApiRequest
    {
        public override string Interface => "IGameServersService";
        public override string InterfaceMethod => "QueryLoginToken";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameServerLoginTokenInfoRequest(string token)
        {
            ServerToken = token;
        }

        [QueryParameter("login_token")]
        public string ServerToken { get; set; }
    }
}
