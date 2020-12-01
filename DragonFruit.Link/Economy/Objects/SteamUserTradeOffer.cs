// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamUserTradeOffer
    {
        [JsonProperty("tradeofferid")]
        public ulong Id { get; set; }

        [JsonProperty("accountid_other")]
        public ulong OtherUserId { get; set; }

        [JsonProperty("expiration_time")]
        public long ExpirationEpoch { get; set; }

        [JsonProperty("time_created")]
        public long CreatedEpoch { get; set; }

        [JsonProperty("time_updated")]
        public long UpdatedEpoch { get; set; }

        [JsonIgnore]
        public DateTimeOffset Expirtation => DateTimeOffset.FromUnixTimeSeconds(ExpirationEpoch);

        [JsonIgnore]
        public DateTimeOffset Created => DateTimeOffset.FromUnixTimeSeconds(CreatedEpoch);

        [JsonIgnore]
        public DateTimeOffset Updated => DateTimeOffset.FromUnixTimeSeconds(UpdatedEpoch);

        //todo to enum
        [JsonProperty("trade_offer_state")]
        public int OfferState { get; set; }

        //todo to enum
        [JsonProperty("confirmation_method")]
        public int ConfirmationMethod { get; set; }

        [JsonProperty("is_our_offer")]
        public bool CreatedByUs { get; set; }

        [JsonProperty("from_real_time_trade")]
        public bool IsFromRealTimeTrade { get; set; }

#nullable enable

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("items_to_receive")]
        public IEnumerable<SteamTradeOfferItem>? ItemsToRecieve { get; set; }

        [JsonProperty("items_to_send")]
        public IEnumerable<SteamTradeOfferItem>? ItemsToSend { get; set; }

#nullable restore
    }
}
