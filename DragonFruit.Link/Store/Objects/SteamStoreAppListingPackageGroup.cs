// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Enums;
using Newtonsoft.Json;

#nullable enable

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListingPackageGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes what the subscriptions are, this will only show if <see cref="DisplayType"/> is set to <see cref="SteamSubscriptionDisplayMode.Dropdown"/>
        /// </summary>
        [JsonProperty("selection_text")]
        public string SelectionText { get; set; }

        /// <summary>
        /// Savings Text
        /// </summary>
        [JsonProperty("save_text")]
        public string SaveText { get; set; }

        [JsonProperty("display_type")]
        public SteamSubscriptionDisplayMode DisplayType { get; set; }

        [JsonProperty("is_recurring_subscription")]
        public bool IsRecurringSubscription { get; set; }

        [JsonProperty("subs")]
        public IEnumerable<SteamStoreAppListingPackages> Subscriptions { get; set; }
    }
}
