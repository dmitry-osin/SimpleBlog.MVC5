using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataService;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.WebUI.Utils
{
    public static class AppSettingsStore
    {
        private static UnitOfWork _unitOfWork;

        public static Setting GetDateFormat()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("DateFormat");
            }
        }
        
        public static Setting GetBlogName()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("BlogName");
            }
        }


        public static Setting GetPersistenceTimeOfAuth()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("PersistenceTimeOfAuth");
            }
        }


        public static Setting GetPostsPerPage()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("PostsPerPage");
            }
        }

        public static Setting GetDefaultUserRole()
        {
            using (_unitOfWork = new UnitOfWork(ApplicationContext.Create()))
            {
                return _unitOfWork.Settings.GetByName("DefaultUserRole");
            }
        }
    }
}