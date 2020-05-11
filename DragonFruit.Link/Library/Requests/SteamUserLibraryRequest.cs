﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data.Parameters;

#nullable enable

namespace DragonFruit.Link.Library.Requests
{
    public class SteamUserLibraryRequest : SteamApiRequest, IForSteamUser
    {
        public override string Interface => "IPlayerService";
        public override string InterfaceMethod => "GetOwnedGames";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamUserLibraryRequest(ulong steamId)
        {
            Id = steamId;
        }

        public SteamUserLibraryRequest(ulong steamId, bool includeF2P)
            : this(steamId)
        {
            IncludeFreeGames = includeF2P;
        }

        [QueryParameter("steamid")]
        public ulong Id { get; set; }

        [QueryParameter("include_appinfo")]
        public bool? IncludeAppInfo { get; set; } = true;

        [QueryParameter("include_played_free_games")]
        public bool? IncludeFreeGames { get; set; }

        //todo fix this part - currently getting 500x errors
        //public IEnumerable<uint>? FilteredApps { get; set; }

        // see https://developer.valvesoftware.com/wiki/Steam_Web_API#GetOwnedGames_.28v0001.29
        //[QueryParameter("input_json")]
        //private string? FilteredAppString => FilteredApps == null ? null : $"{{ \"appids_filter\": [ {string.Join(", ", FilteredApps)} ] }}";
    }

}
