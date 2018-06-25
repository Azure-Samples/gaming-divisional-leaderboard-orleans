// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Leaderboard.Interfaces;
using Microsoft.Extensions.Logging;
using Orleans;

namespace Leaderboard.Grains
{
    public class LeaderboardGrain : Grain, ILeaderboard
    {
        private readonly ILogger _logger;

        public LeaderboardGrain(ILogger<LeaderboardGrain> logger)
        {
            this._logger = logger;
        }

        public Task<string> SetupTest(string message)
        {
            _logger.LogInformation("INFO: Message recived =>" + message);
            return Task.FromResult("OK!");
        }
    }
}