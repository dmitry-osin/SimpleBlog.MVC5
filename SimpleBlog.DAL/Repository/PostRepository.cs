using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataContracts;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.Repository
{
    /// <summary>
    /// Post Repository
    /// </summary>
    /// <seealso cref="SimpleBlog.DAL.DataContracts.IPostRepository" />
    public class PostRepository : IPostRepository
    {
        private ApplicationContext _context;

        public PostRepository(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(Post entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(Post entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Remove(Post entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        /// <summary>
        /// Gets all published.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Post> GetAllPublished()
        {
            return _context.Posts.ToList();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Post Get(int id)
        {
            return _context.Posts.Find(id);
        }
    }
}
