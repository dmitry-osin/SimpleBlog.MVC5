using System.Collections.Generic;

namespace SimpleBlog.DAL.ViewModel
{
    public class PostsListViewModel
    {
        public IEnumerable<PostViewModel> PostViewModels { get; set; }
        public PagingInfoViewModel PagingInfoViewModel { get; set; }
    }
}