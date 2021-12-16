// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Link.Economy.Requests
{
    public class SteamGameEconomyAssetInfoRequest : SteamApiRequest, IForSteamApp, IHasOptionalLanguage
    {
        public override string Interface => "ISteamEconomy";
        public override string InterfaceMethod => "GetAssetClassInfo";

        public override int MethodVersion => 1;

        public override bool RequireApiKey => true;

        public SteamGameEconomyAssetInfoRequest(uint appId, IEnumerable<ulong> classes)
        {
            AppId = appId;
            Classes = classes;
        }

        [QueryParameter("appid")]
        public uint AppId { get; set; }

        [QueryParameter("language")]
        public string LanguageCode { get; set; }

        public IEnumerable<ulong>? Instances { get; set; }

        public IEnumerable<ulong> Classes { get; set; }

        [QueryParameter("class_count")]
        private string CompiledQuery
        {
            get
            {
                var stringBuilder = new StringBuilder();
                var totalClasses = Classes.Count();

                if (totalClasses > 1)
                {
                    throw new InvalidOperationException("Must be at least one class to generate a valid query");
                }

                stringBuilder.Append(totalClasses);

                for (var i = 0; i < totalClasses; i++)
                {
                    stringBuilder.Append($"&classid{i}={Classes.ElementAt(i)}");
                }

                if (Instances != null)
                {
                    for (int i = 0; i < Instances.Count(); i++)
                    {
                        stringBuilder.Append($"&instanceid{i}={Instances.ElementAt(i)}");
                    }
                }

                return stringBuilder.ToString();
            }
        }
    }
}
