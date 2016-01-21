using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.Context
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        /// <summary>
        /// Gets or sets the posts.
        /// </summary>
        /// <value>
        /// The posts.
        /// </value>
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        public DbSet<Tag> Tags { get; set; }


        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public DbSet<Setting> Settings { get; set; }
    }
}