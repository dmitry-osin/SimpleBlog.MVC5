using System;
using System.Configuration;

namespace SimpleBlog.WebUI
{
    public static class SettingsProvider
    {
        /// <summary>
        /// Gets the date format.
        /// </summary>
        /// <value>
        /// The date format.
        /// </value>
        public static string DateFormat
        {
            get { return ConfigurationManager.AppSettings["DateFormat"]; }
        }

        /// <summary>
        /// Gets the name of the blog.
        /// </summary>
        /// <value>
        /// The name of the blog.
        /// </value>
        public static string BlogName
        {
            get { return ConfigurationManager.AppSettings["BlogName"]; }
        }

        /// <summary>
        /// Gets the persistence time of authentication.
        /// </summary>
        /// <value>
        /// The persistence time of authentication.
        /// </value>
        public static int PersistenceTimeOfAuth
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PersistenceTime"]); }
        }
    }
}