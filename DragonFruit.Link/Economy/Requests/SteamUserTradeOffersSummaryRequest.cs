// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamUserTradeOffersSummaryRequest : SteamApiRequest
    {
        public override string Interface => "IEconService";
        public override string InterfaceMethod => "GetTradeOffersSummary";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public DateTimeOffset LastVisted { get; set; } = DateTimeOffset.Now.AddDays(-7);

        [QueryParameter("time_last_visit")]
        private double? LastVisitedEpoch => EpochFromDate(LastVisted);
    }
}
