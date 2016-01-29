using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataService;
using SimpleBlog.DAL.Object_Model;
using SimpleBlog.DAL.ViewModel;

namespace SimpleBlog.WebUI.Areas.Admin.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private UnitOfWork _unitOfWork;

        public PostController()
        {
            _unitOfWork = new UnitOfWork(ApplicationContext.Create());
        }

        [HttpGet]
        public async Task<ActionResult> Posts()
        {
            var posts = await _unitOfWork.DataContext.Posts.ToListAsync();
            if (posts.Any())
            {
                return View(Mapper.Map<IEnumerable<Post>, IEnumerable<PostViewModel>>(posts));
            }
            return View("Create");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new PostViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                var post = _unitOfWork.DataContext.Posts.FirstOrDefault(x => x.UrlSlug == model.UrlSlug);
                if (post != null)
                {
                    ModelState.AddModelError("", "Такой пост уже существует.");
                }
                else
                {
                    // TODO: Стремное решение

                    model.Author = _unitOfWork.DataContext.Users.Find(User.Identity.GetUserId());
                    _unitOfWork.Posts.Add(Mapper.Map<PostViewModel, Post>(model));
                    _unitOfWork.Save();
                    return RedirectToRoute(new { area = "", controller = "Blog", action = "Details", url = model.UrlSlug });
                }
            }
            return RedirectToAction("Create");
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var post = await _unitOfWork.DataContext.Posts.FindAsync(id);
                if (post != null)
                {
                    return View(Mapper.Map<Post, PostViewModel>(post));
                }
            }
            return HttpNotFound();
        }

        [HttpPost]
        public async Task<ActionResult> Edit(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                await Task.Run(() =>
                {
                    _unitOfWork.Posts.Update(Mapper.Map<PostViewModel, Post>(model));
                    _unitOfWork.Save();
                });

                return RedirectToRoute(new { area = "", controller = "Blog", action = "Details", url = model.UrlSlug });
            }
            return RedirectToRoute(new { area = "Admin", controller = "Post", action = "Posts" });
        }

        [HttpGet]
        public async Task<ActionResult> Remove(int? id)
        {
            if (id.HasValue)
            {
                var model = await _unitOfWork.DataContext.Posts.FindAsync(id.Value);
                return View(model);
            }
            return HttpNotFound();
        }
        
        [HttpPost]
        public ActionResult Remove(Post post)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Posts.Remove(post);
                _unitOfWork.Save();
                return RedirectToAction("Posts");
            }
            return HttpNotFound();
        }
    }
}