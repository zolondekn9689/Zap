using System;
using Zap.Shared.Models;

namespace Zap.Shared.Abstractions
{
    public interface IFileService
    {
        public Task<ConfigModel> GetConfigFile();
    }
}

