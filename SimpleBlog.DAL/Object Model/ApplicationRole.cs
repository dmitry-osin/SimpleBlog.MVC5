using Microsoft.AspNet.Identity.EntityFramework;

namespace SimpleBlog.DAL.Object_Model
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public string Description { get; set; } 
    }
}