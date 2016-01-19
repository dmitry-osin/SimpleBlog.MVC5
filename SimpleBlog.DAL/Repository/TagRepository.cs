using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.Repository
{
    public class TagRepository
    {
        private ApplicationContext _context;

        public TagRepository(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(Tag entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(Tag entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Remove(Tag entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tag> GetAll()
        {
            return _context.Tags.ToList();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Tag Get(int id)
        {
            return _context.Tags.Find(id);
        } 
    }
}