// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeDeclineRequest : SteamApiRequest
    {
        public override Methods Method => Methods.Post;
        public override DataTypes DataType => DataTypes.Encoded;

        public override string Interface => "IEconService";
        public override string InterfaceMethod => "DeclineTradeOffer";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserTradeDeclineRequest(ulong offerId)
        {
            OfferId = offerId;
        }

        [FormParameter("tradeofferid")]
        public ulong OfferId { get; set; }
    }
}
