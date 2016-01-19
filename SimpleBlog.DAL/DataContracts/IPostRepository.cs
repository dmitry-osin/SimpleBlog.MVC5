using System.Collections.Generic;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.DataContracts
{
    public interface IPostRepository : IMainRepositoryOperations<Post>
    {
        IEnumerable<Post> GetAllPublished();
    }
}