using monsterhunterAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace monsterhunterAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Context = new ApplicationDbContext();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
