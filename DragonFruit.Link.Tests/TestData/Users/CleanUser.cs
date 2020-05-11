﻿// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

using System;

namespace DragonFruit.Link.Tests.TestData.Users
{
    public class SteamCleanUser : ITestUser
    {
        public ulong Id => Convert.ToUInt64("11000010C4C8A92", 16);
        
        public string CustomUrlSegment => "papa_curry";

        public string Url => $"https://steamcommunity.com/id/{CustomUrlSegment}";

        public int MinBadges => 12;

        public int MinLevel => 30;

        public uint MinGames => 25;

        public uint MinKillsCounterStrike => 20000;

        public uint MinKillsTeamFortress => 500;

        public bool VACBanned => false;

        public bool CommunityBanned => false;

        public int GameBanned => 0;
    }
}
