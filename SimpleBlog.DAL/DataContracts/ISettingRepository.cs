using System.Collections.Generic;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.DataContracts
{
    public interface ISettingRepository<T>
    {
        void Update(T entity);
        T GetById(int id);
        T GetByName(string name);
        IEnumerable<T> GetAll();
    }
}