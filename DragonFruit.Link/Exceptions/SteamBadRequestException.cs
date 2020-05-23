// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;

namespace DragonFruit.Link.Exceptions
{
    public class SteamBadRequestException : Exception
    {
        public SteamBadRequestException()
            : base("The SteamApiRequest was not formed correctly. Please check what data was entered and try again")
        {
        }
    }
}
