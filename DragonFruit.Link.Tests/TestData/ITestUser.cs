// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

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
