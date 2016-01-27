using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataService;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.WebUI.Utils
{
    public class AppSettingsStore
    {
        private UnitOfWork _unitOfWork;

        public AppSettingsStore()
        {
            _unitOfWork = new UnitOfWork(ApplicationContext.Create());
        }

        public Setting DateFormat
        {
            get { return _unitOfWork.Settings.GetByName("DateFormat"); }
            set
            {
                _unitOfWork.Settings.Update(value);
            }
        }


        public Setting BlogName
        {
            get { return _unitOfWork.Settings.GetByName("BlogName"); }
            set
            {
                _unitOfWork.Settings.Update(value);
            }
        }


        public Setting PersistenceTimeOfAuth
        {
            get { return _unitOfWork.Settings.GetByName("PersistenceTimeOfAuth"); }
            set
            {
                _unitOfWork.Settings.Update(value);
            }
        }


        public Setting PostsPerPage
        {
            get { return _unitOfWork.Settings.GetByName("PostsPerPage"); }
            set
            {
                _unitOfWork.Settings.Update(value);
            }
        }
    }
}