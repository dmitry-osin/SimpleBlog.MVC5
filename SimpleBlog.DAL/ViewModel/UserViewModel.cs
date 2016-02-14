using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace SimpleBlog.DAL.ViewModel
{
    public class UserViewModel
    {
        [HiddenInput]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Полное имя")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Пароль")]
        public string PasswordHash { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Штапм безопасности")]
        public string SecurityStamp { get; set; }
    }
}