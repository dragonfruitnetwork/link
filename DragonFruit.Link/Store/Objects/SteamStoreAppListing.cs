// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System.Collections.Generic;
using DragonFruit.Link.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamStoreAppListing
    {
        [JsonProperty("type")]
        public SteamListingType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("steam_appid")]
        public uint AppId { get; set; }

        [JsonProperty("required_age")]
        public int MinimumAge { get; set; }

        [JsonProperty("is_free")]
        public bool IsFree { get; set; }

        [JsonProperty("controller_support")]
        public SteamControllerSupport ControllerSupport { get; set; }

        [JsonProperty("background")]
        public string BackgroundUrl { get; set; }

        #region Descriptions

        [JsonProperty("detailed_description")]
        public string HtmlDescription { get; set; }

        [JsonProperty("about_the_game")]
        public string HtmlAbout { get; set; }

        [JsonProperty("short_description")]
        public string HtmlShortDescription { get; set; }

        [JsonProperty("supported_languages")]
        public string HtmlSupportedLanguages { get; set; }

        #endregion

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        #region Requirements

        [JsonProperty("pc_requirements")]
        private JToken WindowsRequirementsSetter
        {
            set
            {
                try
                {
                    WindowsRequirements = value.ToObject<SteamStoreAppRequirements>();
                }
                catch
                {
                    WindowsRequirements = null;
                }
            }
        }

        [JsonProperty("linux_requirements")]
        private JToken LinuxRequirementsSetter
        {
            set
            {
                try
                {
                    LinuxRequirements = value.ToObject<SteamStoreAppRequirements>();
                }
                catch
                {
                    LinuxRequirements = null;
                }
            }
        }

        [JsonProperty("mac_requirements")]
        private JToken MacRequirementsSetter
        {
            set
            {
                try
                {
                    MacRequirements = value.ToObject<SteamStoreAppRequirements>();
                }
                catch
                {
                    MacRequirements = null;
                }
            }
        }

        #nullable enable

        public SteamStoreAppRequirements? WindowsRequirements { get; set; }
        public SteamStoreAppRequirements? LinuxRequirements { get; set; }
        public SteamStoreAppRequirements? MacRequirements { get; set; }

        #nullable restore

        #endregion

        #region Staff

        [JsonProperty("developers")]
        public IEnumerable<string> Developers { get; set; }

        [JsonProperty("publishers")]
        public IEnumerable<string> Publishers { get; set; }

        #endregion

        #region Stock

        [JsonProperty("packages")]
        public IEnumerable<uint> PackageIds { get; set; }

        [JsonProperty("package_groups")]
        public IEnumerable<SteamStoreAppListingPackages> PackageGroups { get; set; }

        #nullable enable

        [JsonProperty("dlc")]
        public IEnumerable<uint>? AvailableDLCs { get; set; }

        #nullable restore

        #endregion

        #region Tags

        [JsonProperty("categories")]
        public IEnumerable<SteamStoreCategory> Categories { get; set; }

        [JsonProperty("genres")]
        public IEnumerable<SteamStoreCategory> Genres { get; set; }

        #endregion

        #region Visuals

        [JsonProperty("screenshots")]
        public IEnumerable<SteamStoreAppListingScreenshot> Screenshots { get; set; }

        #nullable enable

        [JsonProperty("movies")]
        public IEnumerable<SteamStoreAppListingVideo>? Videos { get; set; }

        #nullable restore

        #endregion

        [JsonProperty("recommendations")]
        public SteamStoreAppListingRecommendationsContainer Recommendations { get; set; }

        [JsonProperty("support_info")]
        public SteamStoreAppListingSupport Support { get; set; }

        [JsonProperty("release_date")]
        public SteamStoreAppListingReleaseInfo Release { get; set; }

        #nullable enable

        [JsonProperty("legal_notice")]
        public string LegalNotice { get; set; }

        [JsonProperty("ext_user_account_notice")]
        public string ExternalAccountNotice { get; set; }

        [JsonProperty("metacritic")]
        public SteamStoreAppListingMetacriticReview? Metacritic { get; set; }

        [JsonProperty("price_overview")]
        public SteamStoreAppListingPriceOverview? PriceOverview { get; set; }

        [JsonProperty("achievements")]
        public SteamStoreAppListingAchievementsContainer? Achievements { get; set; }

        [JsonProperty("content_descriptors")]
        public SteamStoreAppListingContentInfo? ContentDescriptors { get; set; }

        #nullable restore
    }

    public class SteamStoreAppListingRecommendationsContainer
    {
        [JsonProperty("total")]
        public uint TotalRecommendations { get; set; }
    }
}
