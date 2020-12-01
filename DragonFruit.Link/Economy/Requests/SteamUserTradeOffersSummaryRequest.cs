// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using DragonFruit.Common.Data.Parameters;

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
