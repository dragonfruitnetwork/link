// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link
{
    /// <summary>
    /// Base for a <see cref="SteamApiRequest"/> where one of the parameters is a comma-separated string of <see cref="Ids"/>
    /// </summary>
    public abstract class SteamCompiledSteamIdRequest : SteamApiRequest
    {
        protected SteamCompiledSteamIdRequest(ulong user)
        {
            Ids = new[] { user };
        }

        protected SteamCompiledSteamIdRequest(IEnumerable<ulong> users)
        {
            Ids = users;
        }

        public IEnumerable<ulong> Ids { get; set; }

        [QueryParameter("steamids")]
        protected string CompiledIds => string.Join(',', Ids);
    }
}
