using System;

namespace SimpleBlog.DAL.ViewModel
{
    public class PagingInfoViewModel
    {
        // Кол-во товаров
        public int TotalPosts { get; set; }

        // Кол-во товаров на одной странице
        public int PostsPerPage { get; set; }

        // Номер текущей страницы
        public int CurrentPage { get; set; }

        // Общее кол-во страниц
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalPosts / PostsPerPage); }
        } 
    }
}