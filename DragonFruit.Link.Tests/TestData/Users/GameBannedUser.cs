// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;

namespace DragonFruit.Link.Tests.TestData.Users
{
    public class SteamGameBannedUser : ITestUser
    {
        public ulong Id => Convert.ToUInt64("1100001001CF5F9", 16);

        public string CustomUrlSegment => string.Empty;

        public string Url => $"https://steamcommunity.com/profiles/{Id}";

        public int MinBadges => 110;

        public int MinLevel => 70;

        public uint MinGames => 70;

        public uint MinKillsCounterStrike => 2000;

        public uint MinKillsTeamFortress => 600;

        public bool VACBanned => false;

        public bool CommunityBanned => false;

        public int GameBanned => 1;
    }
}
