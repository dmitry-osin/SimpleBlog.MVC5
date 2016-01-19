using System.Collections.Generic;

namespace SimpleBlog.DAL.Object_Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}