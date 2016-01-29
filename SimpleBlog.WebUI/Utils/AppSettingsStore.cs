using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataService;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.WebUI.Utils
{
    public static class AppSettingsStore
    {
        private static UnitOfWork _unitOfWork;

        /// <summary>
        /// Gets the date format.
        /// </summary>
        /// <returns></returns>
        public static Setting GetDateFormat()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("DateFormat");
            }
        }

        /// <summary>
        /// Gets the name of the blog.
        /// </summary>
        /// <returns></returns>
        public static Setting GetBlogName()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("BlogName");
            }
        }


        /// <summary>
        /// Gets the persistence time of authentication.
        /// </summary>
        /// <returns></returns>
        public static Setting GetPersistenceTimeOfAuth()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("PersistenceTimeOfAuth");
            }
        }


        /// <summary>
        /// Gets the posts per page.
        /// </summary>
        /// <returns></returns>
        public static Setting GetPostsPerPage()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("PostsPerPage");
            }
        }

        /// <summary>
        /// Gets the default user role.
        /// </summary>
        /// <returns></returns>
        public static Setting GetDefaultUserRole()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("DefaultUserRole");
            }
        }
    }
}