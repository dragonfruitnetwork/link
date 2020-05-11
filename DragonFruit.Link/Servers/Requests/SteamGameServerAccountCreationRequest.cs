// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Servers.Requests
{
    public class SteamGameServerAccountCreationRequest : SteamApiRequest, IForSteamApp
    {
        public override Methods Method => Methods.Post;
        public override DataTypes DataType => DataTypes.Encoded;

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
