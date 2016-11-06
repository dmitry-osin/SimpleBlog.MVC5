using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataContracts;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.Repository
{
    public class SettingRepository : ISettingRepository<Setting>
    {
        private readonly ApplicationContext _context;

        public SettingRepository(ApplicationContext context)
        {
            _context = context;
        }


        public void Update(Setting entity)
        {
            lock (_context)
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public Setting GetById(int id)
        {
            return _context.Settings.Find(id);
        }

        public Setting GetByName(string name)
        {
            return _context.Settings.FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<Setting> GetAll()
        {
            return _context.Settings.ToList();
        }
    }
}