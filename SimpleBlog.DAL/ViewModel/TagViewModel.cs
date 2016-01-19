using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.ViewModel
{
    public class TagViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Ссылка")]
        public string UrlSlug { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Записи")]
        public ICollection<Post> Posts { get; set; }
        [Display(Name = "Автор")]
        public ApplicationUser Author { get; set; }
    }
}
