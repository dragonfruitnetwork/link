// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;

namespace DragonFruit.Link.Exceptions
{
    public class SteamApiKeyMissingException : Exception
    {
        public SteamApiKeyMissingException()
            : base("The Steam API key value is null or empty. Requests using the API cannot be performed")
        {
        }
    }
}
