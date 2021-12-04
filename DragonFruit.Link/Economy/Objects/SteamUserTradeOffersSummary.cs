// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamUserTradeOffersSummary
    {
        [JsonProperty("pending_received_count")]
        public uint PendingReceived { get; set; }

        [JsonProperty("new_received_count")]
        public uint NewlyReceived { get; set; }

        [JsonProperty("updated_received_count")]
        public uint UpdatedReceived { get; set; }

        [JsonProperty("historical_received_count")]
        public uint HistoricalReceived { get; set; }

        [JsonProperty("pending_sent_count")]
        public uint PendingSent { get; set; }

        [JsonProperty("newly_accepted_sent_count")]
        public uint NewlyAcceptedSent { get; set; }

        [JsonProperty("updated_sent_count")]
        public uint UpdatedSent { get; set; }

        [JsonProperty("historical_sent_count")]
        public uint EscrowReceived { get; set; }

        [JsonProperty("escrow_received_count")]
        public uint EscrowSent { get; set; }
    }
}
