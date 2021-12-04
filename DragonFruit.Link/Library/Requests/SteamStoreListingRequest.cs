﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using DragonFruit.Common.Data.Parameters;

#nullable enable

namespace DragonFruit.Link.Library.Requests
{
    public class SteamStoreListingRequest : SteamApiRequest, IHasOptionalLanguage
    {
        public override string Interface => "IStoreService";
        public override string InterfaceMethod => "GetAppList";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public DateTimeOffset? ModifiedSince { get; set; }

        [QueryParameter("if_modified_since")]
        private double? ModifiedSinceEpoch => EpochFromDate(ModifiedSince);

        [QueryParameter("have_description_language")]
        public string LanguageCode { get; set; }

        [QueryParameter("include_games")]
        public bool? IncludeGames { get; set; }

        [QueryParameter("include_dlc")]
        public bool? IncludeDLC { get; set; }

        [QueryParameter("include_software")]
        public bool? IncludeSoftware { get; set; }

        [QueryParameter("include_videos")]
        public bool? IncludeVideos { get; set; }

        [QueryParameter("include_hardware")]
        public bool? IncludeHardware { get; set; }

        [QueryParameter("last_appid")]
        public uint? LastAppId { get; set; }

        [QueryParameter("max_results")]
        public uint? MaxEntries { get; set; }
    }
}
