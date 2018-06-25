﻿// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Orleans;

namespace Leaderboard.Interfaces
{
    public interface ILeaderboard : IGrainWithGuidKey
    {
        Task<string> SetupTest(string message);
    }
}