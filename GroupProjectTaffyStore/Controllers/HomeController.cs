using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProjectTaffyStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Order()
        {
            ViewBag.Message = "Your order page.";

            return View();
        }
        public ActionResult Catalog()
        {
            ViewBag.Message = "Your Catalog page.";

            return View();
        }
        public ActionResult Suggestion()
        {
            ViewBag.Message = "Your Suggestion page.";

            return View();
        }

        public ActionResult AdminManage()
        {
            ViewBag.Message = "Your Manage page.";

            return View();
        }
    }
}