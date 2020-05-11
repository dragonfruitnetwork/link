// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link
{
    public abstract class SteamApiRequest : ApiRequest
    {
        #region Overrides

        public override Methods Method => Methods.Get;

        public override string AcceptedContent => "application/json";

        #endregion

        #region Authentication

        //we use the RequireApiKey instead, as keys need to be sent as a query
        public override bool RequireAuth => false;

        //replaces RequireAuth, see above
        public abstract bool RequireApiKey { get; }

        [QueryParameter("key"), JsonIgnore]
        public string ApiKey { get; set; }

        #endregion

        #region Path Constructors
        
        public virtual string? PathOverride { get; }

        public override string Path => PathOverride ?? $"https://api.steampowered.com/{Interface}/{InterfaceMethod}/v{MethodVersion}/";

        public abstract int MethodVersion { get; }
    
        public abstract string Interface { get; }

        public abstract string InterfaceMethod { get; }

        #endregion

        [QueryParameter("format")]
        protected string OutputFormat => "json";
    }
}
