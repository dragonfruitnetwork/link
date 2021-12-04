// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
