
using System.Configuration;

namespace DeckCardProject.Config
{
    static class Configuration
    {
        static Configuration()
        {
            BaseURL = ConfigurationManager.AppSettings["BaseURL"].ToString();
            RelativeURL = ConfigurationManager.AppSettings["RelativeURL"].ToString();
        }

        public static string BaseURL { get; set; }
        public static string RelativeURL { get; set; }
    }
}
