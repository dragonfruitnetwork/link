// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
