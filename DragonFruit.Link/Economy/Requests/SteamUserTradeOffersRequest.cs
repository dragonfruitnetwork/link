﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeOffersRequest : SteamApiRequest, IHasOptionalLanguage, IHasOptionalDescription
    {
        public override string Interface => "IEconService";
        public override string InterfaceMethod => "GetTradeOffers";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        [QueryParameter("get_sent_offers")]
        public bool? IncludeSentOffers { get; set; } = true;

        [QueryParameter("get_received_offers")]
        public bool? IncludeRecievedOffers { get; set; } = true;

        [QueryParameter("get_descriptions")]
        public bool? IncludeDescriptions { get; set; } = true;

        [QueryParameter("language")]
        public string LanguageCode { get; set; }

        [QueryParameter("active_only")]
        public bool? ActiveOnly { get; set; }

        [QueryParameter("historical_only")]
        public bool? InactiveOnly { get; set; }

        public DateTimeOffset? ActiveOnlyAfter { get; set; }

        [QueryParameter("time_historical_cutoff")]
        private double? ActiveOnlyAfterEpoch => EpochFromDate(ActiveOnlyAfter);
    }
}
