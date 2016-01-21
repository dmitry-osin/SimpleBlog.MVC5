using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.DataContracts
{
    public interface ISettingRepository<T>
    {
        void Update(T entity);
        T Read();
    }
}