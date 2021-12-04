// DragonFruit Link Copyright (C) DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENCE file for more info

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DragonFruit.Link.Tests.TestData;
using DragonFruit.Link.Tests.TestData.Users;

namespace DragonFruit.Link.Tests
{
    /// <summary>
    /// Inheritable class that exposes a <see cref="SteamApiClient"/> and a list of users to use
    /// </summary>
    public abstract class SteamApiTest
    {
        private static SteamApiClient _client;
        private static IEnumerable<ITestUser> _testUsers;

        private const string VariableName = "steam";

        protected SteamApiTest()
        {
            // idk... see *SonarCSharp_S1118*
        }

        protected static SteamApiClient Client => _client ??= new SteamApiClient(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? Environment.GetEnvironmentVariable(VariableName, EnvironmentVariableTarget.User) ?? Environment.GetEnvironmentVariable(VariableName, EnvironmentVariableTarget.Machine) ?? Environment.GetEnvironmentVariable(VariableName)
            : Environment.GetEnvironmentVariable(VariableName));

        protected static IEnumerable<ITestUser> Users => _testUsers ??= new ITestUser[] { new SteamCleanUser(), new SteamGameBannedUser() };
    }
}
