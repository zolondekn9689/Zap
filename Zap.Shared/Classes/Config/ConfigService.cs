using System;
using Zap.Shared.Abstractions;
using Zap.Shared.Models;
using Newtonsoft.Json;

namespace Zap.Shared.Services
{
    public class ConfigService : IFileService
    {
        
        private ConfigModel _config = null;

        public ConfigService()
        {
            System.IO.Directory.CreateDirectory(Directory);
            if (!File.Exists(ConfigFilePath))
                NewConfigFile();
            
        }

        public string Directory { get => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Zap");  }
        public string ConfigFilePath { get => Path.Combine(Directory, "Config.txt");  }

        public async Task<ConfigModel> GetConfigFile()
        {
            if (_config != null)
                return _config;

            using (var stream = File.OpenRead(ConfigFilePath))
            using (var reader = new StreamReader(stream))
            {
                var json = await reader.ReadToEndAsync();
                _config = JsonConvert.DeserializeObject<ConfigModel>(json);
            }

            return _config;
        }

        private void NewConfigFile()
        {
            var config = new ConfigModel();
            
            using (var stream = File.Create(ConfigFilePath))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(JsonConvert.SerializeObject(config));
                }
            }
        }
    }
}

