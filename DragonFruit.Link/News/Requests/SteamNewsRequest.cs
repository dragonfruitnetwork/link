// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

#nullable enable

namespace DragonFruit.Link.News.Requests
{
    public class SteamNewsRequest : SteamApiRequest
    {
        public override string Interface => "ISteamNews";
        public override string InterfaceMethod => "GetNewsForApp";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => false;

        public SteamNewsRequest(uint appId)
        {
            AppId = appId;
        }

        public SteamNewsRequest(uint appId, uint limit)
            : this(appId)
        {
            Count = limit;
        }

        public SteamNewsRequest(uint appId, uint limit, uint maxDescriptionLength)
            : this(appId)
        {
            Count = limit;
            MaxDescriptionLength = maxDescriptionLength;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("count")]
        public uint? Count { get; set; }

        [QueryParameter("maxlength")]
        public uint? MaxDescriptionLength { get; set; }

        public DateTimeOffset? EarlierThan { get; set; }

        [QueryParameter("feeds", CollectionConversionMode.Concatenated)]
        public IEnumerable<string> Feeds { get; set; }

        [QueryParameter("tags", CollectionConversionMode.Concatenated)]
        public IEnumerable<string> Tags { get; set; }

        [QueryParameter("enddate")]
        private double? Epoch => EpochFromDate(EarlierThan);
    }
}
