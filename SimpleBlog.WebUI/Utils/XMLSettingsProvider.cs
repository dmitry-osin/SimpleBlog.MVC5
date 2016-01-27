using System.Configuration;

namespace SimpleBlog.WebUI.Utils
{
    public static class XMLSettingsProvider
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

        /// <summary>
        /// Gets the posts per page.
        /// </summary>
        /// <value>
        /// The posts per page.
        /// </value>
        public static int PostsPerPage
        {
            get { return int.Parse(ConfigurationManager.AppSettings["PostsPerPage"]); }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is initialize database.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is initialize database; otherwise, <c>false</c>.
        /// </value>
        public static bool IsInitDb
        {
            get { return bool.Parse(ConfigurationManager.AppSettings["InitDatabase"]); }
        }

        /// <summary>
        /// Gets the default user.
        /// </summary>
        /// <value>
        /// The default user.
        /// </value>
        public static string DefaultUser
        {
            get { return ConfigurationManager.AppSettings["DefaultUserName"]; }
        }

        /// <summary>
        /// Gets the default name of the user full.
        /// </summary>
        /// <value>
        /// The default name of the user full.
        /// </value>
        public static string DefaultUserFullName
        {
            get { return ConfigurationManager.AppSettings["DefaultUserFullName"]; }
        }

        /// <summary>
        /// Gets the default user email.
        /// </summary>
        /// <value>
        /// The default user email.
        /// </value>
        public static string DefaultUserEmail
        {
            get { return ConfigurationManager.AppSettings["DefaultUserEmail"]; }
        }

        /// <summary>
        /// Gets the default user password.
        /// </summary>
        /// <value>
        /// The default user password.
        /// </value>
        public static string DefaultUserPassword
        {
            get { return ConfigurationManager.AppSettings["DefaultUserPassword"]; }
        }
    }
}