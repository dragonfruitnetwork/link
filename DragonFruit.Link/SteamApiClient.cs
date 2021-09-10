// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Serializers;
using DragonFruit.Link.Exceptions;

namespace DragonFruit.Link
{
    public class SteamApiClient : ApiClient<ApiJsonSerializer>
    {
        private readonly string _apiKey;
        private readonly bool _apiKeySet;

        #region Constructors

        public SteamApiClient(string apiKey)
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
