using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DailyDairy.Controllers
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

        public ActionResult Login()
        { return View(); }


        [HttpPost]
        public ActionResult LoginVerify()
        {
            String login = Request.Form["username"];
            String password = Request.Form["password"];

            if (login=="admin" && password=="admin")
                return RedirectToAction("Index");
            else
            {
                ViewBag.ErrMsg = "Invalid User Id/Password";
                return RedirectToAction("Login");
            }
        }

    }
}