using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataContracts;
using SimpleBlog.DAL.DataService;

namespace SimpleBlog.WebUI.Controllers
{

    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult AboutMe()
        {
            ViewBag.Title = "Обо мне";
            ViewBag.Description = "Обо мне";
            return View();
        }

        [Route("~/contacts")]
        public ActionResult Contacts()
        {
            return View();
        }

        [Route("~/skills")]
        public ActionResult Skills()
        {
            return View();
        }

        [Route("~/portfolio")]
        public ActionResult Portfolio()
        {
            return View();
        }

        [Route("~/сertificates")]
        public ActionResult Certificates()
        {
            return View();
        }
    }
}