// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;

namespace DragonFruit.Link.Tests.TestData.Users
{
    public class SteamGameBannedUser : ITestUser
    {
        public ulong Id => Convert.ToUInt64("110000140F717BB", 16);

        public string CustomUrlSegment => string.Empty;

        public string Url => $"https://steamcommunity.com/profiles/{Id}";

        public int MinBadges => 40;

        public int MinLevel => 45;

        public uint MinGames => 55;

        public uint MinKillsCounterStrike => 1500;

        public uint MinKillsTeamFortress => 1;

        public bool VACBanned => true;

        public bool CommunityBanned => false;

        public int GameBanned => 1;
    }
}
