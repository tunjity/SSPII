using ExcelDataReader.Log;
using Newtonsoft.Json;

namespace SSP.Infrastructure.Utility
{
    public class ConfigHelpers
    {
        private static ConfigHelpers _appSettings;
        private static string _section;

        public string appSettingValue { get; set; }

        public static string GetLocalSetting(string section = "", string key = "")
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();
            var settings = new ConfigHelpers(configuration.GetSection(section), key);

            return settings.appSettingValue;
        }


        public static string AppSetting(string section = "", string key = "")
        {
            string val = string.Empty;
            try
            {
                //if (_appMode == "local")
                //{
                    _section = section;
                    _appSettings = GetCurrentSettings(key);
                    val = _appSettings.appSettingValue;
                //}
                //else
                //{
                //    #region Url, Fetching Key & AppName:

                //    string _configServiceUrl = GetLocalSetting("App", "ConfigServerUrl"),
                //        _configKey = GetLocalSetting("App", "ConfigKey"),
                //        _appName = GetLocalSetting("App", "AppName");
                //    _configServiceUrl = _configServiceUrl + $"{_appMode}/{_appName}/{section}:{key}";

                //    #endregion

                //    #region Call Config Server:

                //    val = RouteHelper.ProxyHelper(new ApiLinkDTO
                //    {
                //        body = "",
                //        final_url = _configServiceUrl.ToLower(),
                //        headers = JsonConvert.SerializeObject(new { api_key = _configKey }),
                //        method = "GET"
                //    });
                //    val = JsonConvert.DeserializeObject<string>(val);
                //    #endregion
                //}
            }
            catch (Exception ex)
            {
               // LogManager.SendErrorToText(ex);
            }
            return val;
        }

        public ConfigHelpers(IConfiguration config, string Key)
        {
            appSettingValue = config.GetValue<string>(Key);
        }

        public static ConfigHelpers GetCurrentSettings(string key)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            var settings = new ConfigHelpers(configuration.GetSection(_section), key);
            return settings;
        }
    }
}
