// DragonFruit Link API Copyright 2020 (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under the GNU GPLv3 License. Refer to the license.md file at the root of the repo for more info

namespace DragonFruit.Link.Tests.TestData
{
    public interface ITestUser
    {
        public ulong Id { get; }

        public string Url { get; }

        public string CustomUrlSegment { get; }

        public int MinBadges { get; }

        public int MinLevel { get; }

        public uint MinGames { get; }

        public uint MinKillsCounterStrike { get; }

        public uint MinKillsTeamFortress { get; }

        public bool VACBanned { get; }

        public bool CommunityBanned { get; }

        public int GameBanned { get; }
    }
}