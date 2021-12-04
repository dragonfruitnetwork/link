﻿// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Store.Objects
{
    public class SteamFeaturedAppListing
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        //todo is this the same as the ListingType enum?
        [JsonProperty("type")]
        public uint Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        #region Price & Discounts

        [JsonProperty("discounted")]
        public bool IsDiscounted { get; set; }

        [JsonProperty("discount_percent")]
        public uint? DiscountPercent { get; set; }

        [JsonProperty("original_price")]
        public uint? OriginalPrice { get; set; }

        [JsonProperty("final_price")]
        public uint CurrentPrice { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #endregion

        #region Images

        [JsonProperty("large_capsule_image")]
        public string LargeImage { get; set; }

        [JsonProperty("small_capsule_image")]
        public string SmallImage { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        #endregion

        #region Platforms

        [JsonProperty("windows_available")]
        public bool IsOnWindows { get; set; }

        [JsonProperty("linux_available")]
        public bool IsOnLinux { get; set; }

        [JsonProperty("mac_available")]
        public bool IsOnMac { get; set; }

        #endregion

        [JsonProperty("streamingvideo_available")]
        public bool VideoStreamAvailable { get; set; }

        [JsonProperty("discount_expiration")]
        public long DiscountExpirationEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset DiscountExpiration => DateTimeOffset.FromUnixTimeSeconds(DiscountExpirationEpoch);
    }
}
