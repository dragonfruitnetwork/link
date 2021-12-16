// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeDeclineRequest : SteamApiRequest
    {
        protected override Methods Method => Methods.Post;
        protected override BodyType BodyType => BodyType.Encoded;

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
