// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeStatusRequest : SteamApiRequest, IHasOptionalLanguage
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
        public string? LanguageCode { get; set; }
    }
}
