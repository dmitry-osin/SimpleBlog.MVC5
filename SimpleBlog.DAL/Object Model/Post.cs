using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SimpleBlog.DAL.Object_Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [AllowHtml]
        public string ShortDescription { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public string UrlSlug { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}