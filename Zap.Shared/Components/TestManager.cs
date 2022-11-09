using System;
using Zap.Shared.Abstractions;
using Zap.Shared.Extension;
using Zap.Shared.Models;
using Zap.Shared.Services;

namespace Zap.Shared.Components
{
    /// <summary>
    /// TestManager is responsible for starting tests and combining the test results
    /// from all the users. 
    /// </summary>
    public class TestManager
    {
        private readonly ConfigModel config;

        public TestManager(ConfigModel config)
        {
            this.config = config;
        }
        
        public async Task<ZapResults> StartTest(ITest test, HttpRequestMessage msg, int users = 1)
        {
            var tasks = new List<Task>();

            // Make a new list of virtual users.
            for (int userNumber = 1; userNumber <= users; userNumber++)
                tasks.Add((new VirtualUser(config, test, msg).Execute()));

            // Wait for all tasks to finish.
            await Task.WhenAll(tasks);

            // Retrieve results.
            var result = tasks.Interpret();

            // Return results.
            return result;
        }

    }
}

