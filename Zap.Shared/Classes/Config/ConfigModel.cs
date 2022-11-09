using System;
namespace Zap.Shared.Models
{
    public class ConfigModel
    {
        public string Authentication { get; set; } = "ntlm";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Domain { get; set; } = "";
        public string DefaultUrl { get; set; } = "";
        public string DefaultMethod { get; set; } = HttpMethod.Get.ToString();

    }
}

