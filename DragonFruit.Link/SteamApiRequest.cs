// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class SteamApiRequest : ApiRequest
    {
        protected override Methods Method => Methods.Get;
        protected override bool RequireAuth => false; //this only checks headers, ours is in the query

        //replaces RequireAuth, see above
        public abstract bool RequireApiKey { get; }

        #region Path

        public virtual string PathOverride { get; }

        public override string Path => PathOverride ?? $"https://api.steampowered.com/{Interface}/{InterfaceMethod}/v{MethodVersion}/";

        public abstract int MethodVersion { get; }

        public abstract string Interface { get; }

        public abstract string InterfaceMethod { get; }

        #endregion

        [QueryParameter("key")]
        public string ApiKey { get; set; } = null!;

        [QueryParameter("format")]
        protected string OutputFormat => "json";

        protected double? EpochFromDate(DateTimeOffset? date) => date?.Subtract(new DateTimeOffset(1970, 1, 1, 0, 0, 0, date.Value.Offset)).TotalSeconds;
    }
}
