using Newtonsoft.Json;
using ResxManager.Models;
using System.Reflection;

namespace ResxManager.Helpers
{
    public class AppSettingsHelper
    {
        public static string ApiKey { get; set; }
        public static void Load()
        {
            AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText($"{Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().Location).Path))}\\appSettings.json"));
            ApiKey = appSettings.ApiKey;
        }
    }
}
