// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

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
