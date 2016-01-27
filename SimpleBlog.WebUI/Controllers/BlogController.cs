using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataService;
using SimpleBlog.DAL.Object_Model;
using SimpleBlog.DAL.ViewModel;
using SimpleBlog.WebUI.Utils;
using WebGrease.Css.Extensions;

namespace SimpleBlog.WebUI.Controllers
{
    [RoutePrefix("blog")]
    public class BlogController : Controller
    {
        private int _pageSize = 5;
        private UnitOfWork _unitOfWork;
        
        public BlogController()
        {
            _unitOfWork = new UnitOfWork(ApplicationContext.Create());
            _pageSize = int.Parse(AppSettingsStore.GetPostsPerPage().Value);
        }

        [Route("page/{page}")]
        public async Task<ActionResult> Posts(int page = 1)
        {
            ViewBag.Title = "Блог";
            ViewBag.Description = "Блог";

            var posts = await _unitOfWork.DataContext.Posts.Where(x => x.IsPublished).ToListAsync();
            var model = new PostsListViewModel()
            {
                PagingInfoViewModel = new PagingInfoViewModel()
                {
                    CurrentPage = page,
                    PostsPerPage = _pageSize,
                    TotalPosts = posts.Count
                },
                PostViewModels = posts.Select(Mapper.Map<Post, PostViewModel>).OrderBy(p => p.Id).Skip((page - 1) * _pageSize).Take(_pageSize).ToList()
            };
            return View(model);
        }

        [Route("{url?}")]
        public async Task<ActionResult> Details(string url = null)
        {
            ViewBag.Title = "Блог";
            ViewBag.Description = "Блог";

            if (!string.IsNullOrWhiteSpace(url))
            {
                var post = await _unitOfWork.DataContext.Posts.FirstOrDefaultAsync(x => x.UrlSlug == url);
                PostViewModel model = Mapper.Map<Post, PostViewModel>(post);
                return View(model);
            }
            return HttpNotFound();
        }

        [Route("search/{query?}")]
        [HttpPost]
        public async Task<ActionResult> Search(string query)
        {
            ViewBag.Title = "Поиск";
            ViewBag.Description = "Поиск";
            ViewBag.Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                var posts =
                    await
                        _unitOfWork.DataContext.Posts.Where(
                            post =>
                                post.Title.Contains(query) || post.ShortDescription.Contains(query) ||
                                post.Description.Contains(query)).ToListAsync();
                var model = Mapper.Map<IEnumerable<Post>, IEnumerable<PostViewModel>>(posts);
                return View(model);
            }
            return HttpNotFound();
        }

        [Route("tag/{tag?}")]
        public async Task<ActionResult> SearchByTag(string tag)
        {
            return HttpNotFound();
        }
    }
}