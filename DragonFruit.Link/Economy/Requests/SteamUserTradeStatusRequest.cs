// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeStatusRequest : SteamApiRequest, IHasOptionalLanguage, IHasOptionalDescription
    {
        public override string Interface => "IEconService";
        public override string InterfaceMethod => "GetTradeStatus";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserTradeStatusRequest(ulong tradeId)
        {
            TradeId = tradeId;
        }

        [QueryParameter("tradeid")]
        public ulong TradeId { get; set; }

        [QueryParameter("get_descriptions")]
        public bool? IncludeDescriptions { get; set; } = true;

        [QueryParameter("language")]
        public string LanguageCode { get; set; }
    }
}
