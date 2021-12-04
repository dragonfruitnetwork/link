// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeHoldDurationRequest : SteamApiRequest
    {
        public override string Interface => "IEconService";
        public override string InterfaceMethod => "GetTradeHoldDurations";

        public override bool RequireApiKey => true;

        public override int MethodVersion => 1;

        public SteamUserTradeHoldDurationRequest(ulong target, string targetToken)
        {
            TradeTarget = target;
            TradeOfferAccessToken = targetToken;
        }

        [QueryParameter("steamid_target")]
        public ulong TradeTarget { get; set; }

        [QueryParameter("trade_offer_access_token")]
        public string TradeOfferAccessToken { get; set; }
    }
}
