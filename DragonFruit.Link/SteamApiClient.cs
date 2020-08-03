// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Globalization;
using DragonFruit.Common.Data;
using DragonFruit.Link.Exceptions;

namespace DragonFruit.Link
{
    public class SteamApiClient : ApiClient
    {
        private readonly string _apiKey;
        private readonly bool _apiKeySet;

        #region Constructors

        public SteamApiClient()
            : base(CultureInfo.InvariantCulture) // creates a new ApiJsonSerializer
        {
        }

        public SteamApiClient(string apiKey)
            : this()
        {
            _apiKey = apiKey;
            _apiKeySet = true;
        }

        public SteamApiClient(string apiKey, string userAgent)
            : this(apiKey)
        {
            UserAgent = userAgent;
        }

        #endregion

        protected override void ValidateRequest(ApiRequest requestData)
        {
            base.ValidateRequest(requestData);

            if (!(requestData is SteamApiRequest steamRequest))
            {
                return;
            }

            if (!steamRequest.RequireApiKey)
            {
                return;
            }

            if (!_apiKeySet)
            {
                throw new SteamApiKeyMissingException();
            }

            steamRequest.ApiKey = _apiKey;
        }
    }
}
