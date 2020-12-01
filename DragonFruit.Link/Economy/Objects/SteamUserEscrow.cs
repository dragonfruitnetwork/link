// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Link.Economy.Objects
{
    public class SteamUserEscrow
    {
        [JsonProperty("escrow_end_duration_seconds")]
        public uint Duration { get; set; }

        [JsonProperty("escrow_end_date")]
        public ulong? EndDateEpoch { get; set; }

        [JsonProperty("escrow_end_date_rfc3339")]
        public string EndDateString { get; set; }

        [JsonIgnore]
        public DateTimeOffset EndDate => DateTimeOffset.Now.AddSeconds(Duration);
    }
}
