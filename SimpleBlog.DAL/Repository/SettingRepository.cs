using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataContracts;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.Repository
{
    public class SettingRepository : ISettingRepository<Setting>
    {
        private ApplicationContext _context;

        public SettingRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Update(Setting entity)
        {
            throw new System.NotImplementedException();
        }

        public Setting Read()
        {
            throw new System.NotImplementedException();
        }
    }
}