using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.DAL.ViewModel
{
    public class PostViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Название")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        [AllowHtml]
        public string ShortDescription { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Содержание")]
        [AllowHtml]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Ссылка")]
        public string UrlSlug { get; set; }

        [Display(Name = "Опубликовано?")]
        public bool IsPublished { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата публикации")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Метки")]
        public ICollection<Tag> Tags { get; set; }
        [Display(Name = "Автор")]
        public ApplicationUser Author { get; set; }
    }
}