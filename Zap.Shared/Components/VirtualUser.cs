using System;
using System.Net;
using Zap.Shared.Abstractions;
using Zap.Shared.Models;

namespace Zap.Shared.Services
{
    internal class VirtualUser
    {
        private readonly HttpClient client;
        private readonly ITest test;
        private readonly HttpRequestMessage message;
        private readonly int second;

        public VirtualUser(ConfigModel config, ITest test, HttpRequestMessage message, int second = 0)
        {
            this.client = new HttpClient(new HttpClientHandler
            {
                Credentials = new NetworkCredential(config.Username, config.Password, config.Domain)
            });

            this.test = test;
            this.message = message;
            this.second = second;
        }

        internal async Task<ZapResults> Execute()
        {

            var result = await test.Start(client, message);
            
            return result;
        }
    }
}

