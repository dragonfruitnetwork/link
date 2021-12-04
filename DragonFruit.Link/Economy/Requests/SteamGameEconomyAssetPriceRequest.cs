// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamGameEconomyAssetPriceRequest : SteamApiRequest, IForSteamApp, IHasOptionalLanguage
    {
        public override string Interface => "ISteamEconomy";
        public override string InterfaceMethod => "GetAssetPrices";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameEconomyAssetPriceRequest(uint appId)
        {
            AppId = appId;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("currency")]
        public string Currency { get; set; }

        [QueryParameter("language")]
        public string LanguageCode { get; set; }
    }
}
