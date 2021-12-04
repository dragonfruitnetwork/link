// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using DragonFruit.Link.Economy.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Responses
{
    public class SteamUserTradeHoldDurationResponse : ISteamApiResponse
    {
        [JsonProperty("response")]
        public SteamUserTradeHoldDurationContainer HoldDurations { get; set; }
    }

    public class SteamUserTradeHoldDurationContainer
    {
        [JsonProperty("my_escrow")]
        public SteamUserEscrow OurEscrow { get; set; }

        [JsonProperty("their_escrow")]
        public SteamUserEscrow TargetEscrow { get; set; }

        [JsonProperty("both_escrow")]
        public SteamUserEscrow OverallEscrow { get; set; }
    }
}
