using System;
using System.Configuration;

namespace SimpleBlog.WebUI
{
    public static class SettingsPreloader
    {
        public static string DateFormat
        {
            get { return ConfigurationManager.AppSettings["DateFormat"]; }
        }

        public static string BlogName
        {
            get { return ConfigurationManager.AppSettings["BlogName"]; }
        }

        public static int PersistenceTimeOfAuth
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PersistenceTime"]); }
        }
    }
}