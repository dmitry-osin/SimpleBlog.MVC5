using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.WebUI.Areas.Admin.Controllers
{
    [Authorize]
    public class TagManageController : Controller
    {
        // GET: Admin/TagManage
        public ActionResult Tags()
        {
            return View();
        }
    }
}