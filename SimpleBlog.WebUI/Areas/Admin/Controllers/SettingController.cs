using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataService;
using SimpleBlog.DAL.Object_Model;

namespace SimpleBlog.WebUI.Areas.Admin.Controllers
{
    [Authorize]
    public class SettingController : Controller
    {
        private UnitOfWork _unitOfWork;

        public SettingController()
        {
            _unitOfWork = new UnitOfWork(ApplicationContext.Create());
        }

        // GET: Admin/Setting
        public ActionResult List()
        {
            return View(_unitOfWork.Settings.GetAll());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_unitOfWork.Settings.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Setting model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Settings.Update(model);
            }
            return View();
        }
    }
}