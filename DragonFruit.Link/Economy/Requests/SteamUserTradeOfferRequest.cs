// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeOfferRequest : SteamApiRequest, IHasOptionalLanguage, IHasOptionalDescription
    {
        public override string Interface => "IEconService";
        public override string InterfaceMethod => "GetTradeOffer";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserTradeOfferRequest(ulong offerId)
        {
            OfferId = offerId;
        }

        [QueryParameter("tradeofferid")]
        public ulong OfferId { get; set; }

        [QueryParameter("language")]
        public string LanguageCode { get; set; }

        [QueryParameter("get_descriptions")]
        public bool? IncludeDescriptions { get; set; } = true;
    }
}
