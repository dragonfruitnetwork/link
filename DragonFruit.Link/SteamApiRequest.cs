// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using DragonFruit.Data;
using DragonFruit.Data.Parameters;
using DragonFruit.Link.Exceptions;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class SteamApiRequest : ApiRequest
    {
        protected override Methods Method => Methods.Get;
        protected override bool RequireAuth => false; // this only checks headers, ours is in the query

        // replaces RequireAuth, see above
        public abstract bool RequireApiKey { get; }

        public virtual string? PathOverride => null;
        public override string Path => PathOverride ?? $"https://api.steampowered.com/{Interface}/{InterfaceMethod}/v{MethodVersion}/";

        public abstract int MethodVersion { get; }
        public abstract string Interface { get; }
        public abstract string InterfaceMethod { get; }

        [QueryParameter("key")]
        public string ApiKey { get; set; } = null!;

        [QueryParameter("format")]
        protected string OutputFormat => "json";

        protected override void OnRequestExecuting(ApiClient client)
        {
            if (RequireApiKey && string.IsNullOrEmpty(ApiKey))
            {
                ApiKey = client is ISteamApiClient steam ? steam.ApiKey : throw new SteamApiKeyMissingException();
            }
        }

        protected double? EpochFromDate(DateTimeOffset? date) => date?.Subtract(new DateTimeOffset(1970, 1, 1, 0, 0, 0, date.Value.Offset)).TotalSeconds;
    }
}
