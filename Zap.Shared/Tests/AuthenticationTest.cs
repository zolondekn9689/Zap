using System;
using Zap.Shared.Abstractions;
using Zap.Shared.Models;

namespace Zap.Shared.Tests
{
    public class AuthenticationTest : ITest
    {
        public AuthenticationTest()
        {
        }

        public int Seconds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<ZapResults> Start(HttpClient client, HttpRequestMessage httpRequest, int seconds = 30)
        {
            
        }
    }
}

