// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System.Collections.Generic;
using System.Linq;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Link
{
    /// <summary>
    /// Base for a <see cref="SteamApiRequest"/> where one of the parameters is a comma-separated string of <see cref="Ids"/>
    /// </summary>
    public abstract class SteamCompiledIdRequest : SteamApiRequest
    {
        protected SteamCompiledIdRequest(ulong user)
        {
            Ids = new[] { user };
        }

        protected SteamCompiledIdRequest(IEnumerable<ulong> users)
        {
            Ids = users;
        }

        public IEnumerable<ulong> Ids { get; set; }

        [QueryParameter("steamids", CollectionConversionMode.Concatenated)]
        internal IEnumerable<string> ConvertedIds => Ids.Select(x => x.ToString());
    }
}
