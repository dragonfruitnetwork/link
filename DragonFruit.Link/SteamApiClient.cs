// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Net.Http;
using DragonFruit.Common.Data;

namespace DragonFruit.Link
{
    public class SteamApiClient : ApiClient
    {
        private readonly string _apiKey;
        private readonly bool _apiKeySet;

        #region Constructors

        public SteamApiClient(string apiKey, string userAgent)
            : this(apiKey)
        {
            UserAgent = userAgent;
        }

        public SteamApiClient(string apiKey)
        {
            _apiKey = apiKey;
            _apiKeySet = true;
        }

        public SteamApiClient()
        {
            // this should only be for non-auth requiring things
            _apiKeySet = false;
        }

        #endregion

        public T Perform<T>(SteamApiRequest request) where T : class/*, ISteamApiResponse*/
        {
            CheckAuthorization(request);
            return base.Perform<T>(request);
        }

        public HttpResponseMessage Perform(SteamApiRequest request)
        {
            CheckAuthorization(request);
            return base.Perform(request);
        }

        private void CheckAuthorization(SteamApiRequest request)
        {
            if (!request.RequireApiKey)
            {
                return;
            }

            if (!_apiKeySet)
            {
                //todo custom exception
                throw new Exception("No API key was specified when constructing the client.");
            }

            request.ApiKey = _apiKey;
        }
    }
}
