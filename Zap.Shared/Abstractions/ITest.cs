using System;
using Zap.Shared.Components;
using Zap.Shared.Models;

namespace Zap.Shared.Abstractions
{
    public interface ITest
    {
        /// <summary>
        /// Defines the test parameters such as seconds and virtual users.
        /// </summary>
        public TestProperties TestProperties { get; set; }

        /// <summary>
        /// Defines what is executed during a test.
        /// </summary>
        /// <param name="client">The http client that is provided</param>
        /// <param name="httpRequest"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        public Task<ZapResults> Start(HttpClient client, ZapHttpRequest httpRequest, TestProperties properties);
    }
}

