// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Link.Enums;

namespace DragonFruit.Link.User.Requests
{
    public class SteamUserLinkResolveRequest : SteamApiRequest
    {
        public override string Interface => "ISteamUser";
        public override string InterfaceMethod => "ResolveVanityURL";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserLinkResolveRequest(string vanityUrlSlice)
        {
            VanityUrlSlice = vanityUrlSlice;
        }

        /// <summary>
        /// The Vanity url slice (the bit the user chooses)
        /// </summary>
        [QueryParameter("vanityurl")]
        public string VanityUrlSlice { get; set; }

        public SteamUrlType Type { get; set; } = SteamUrlType.Individual;

        [QueryParameter("url_type")]
        private int TypeQuery => (int)Type;
    }
}
