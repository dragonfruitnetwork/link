// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;

namespace DragonFruit.Link.Exceptions
{
    public class SteamRequestFailedException : Exception
    {
        public SteamRequestFailedException()
            : base("The Steam Request failed to produce a valid result")
        {
        }
    }
}
