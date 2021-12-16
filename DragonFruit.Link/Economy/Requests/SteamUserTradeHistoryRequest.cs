// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeHistoryRequest : SteamApiRequest, IHasOptionalLanguage, IHasOptionalDescription
    {
        public override string Interface => "IEconService";
        public override string InterfaceMethod => "GetTradeHistory";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserTradeHistoryRequest(uint maxEntries)
        {
            MaxEntries = maxEntries;
        }

        public SteamUserTradeHistoryRequest(uint maxEntries, DateTimeOffset since)
            : this(maxEntries)
        {
            OnlyAfter = since;
        }

        [QueryParameter("max_trades")]
        public uint MaxEntries { get; set; }

        public DateTimeOffset? OnlyAfter { get; set; }

        [QueryParameter("start_after_time")]
        private double? TradesAfter => OnlyAfter?.Subtract(new DateTimeOffset(1970, 1, 1, 0, 0, 0, OnlyAfter.Value.Offset)).TotalSeconds;

        [QueryParameter("navigating_back")]
        public bool? NavigateBackwards { get; set; }

        [QueryParameter("get_descriptions")]
        public bool? IncludeDescriptions { get; set; } = true;

        [QueryParameter("language")]
        public string LanguageCode { get; set; }

        [QueryParameter("include_failed")]
        public bool? IncludeFailed { get; set; }

        [QueryParameter("include_total")]
        public bool? IncludeTotal { get; set; }
    }
}
