// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using System.Collections.Generic;
using DragonFruit.Data;
using DragonFruit.Data.Parameters;

#nullable enable

namespace DragonFruit.Link.News.Requests
{
    public class SteamNewsRequest : SteamApiRequest
    {
        public override string Interface => "ISteamNews";
        public override string InterfaceMethod => "GetNewsForApp";

        public override int MethodVersion => 2;

        public override bool RequireApiKey => false;

        public SteamNewsRequest(uint appId, uint? limit, uint? maxDescriptionLength)
        {
            AppId = appId;
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
