using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;


namespace DailyDairy.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

       
        [HttpPost]
        public ActionResult LoginPost()
        {
            string uname = Request.Form["username"];

            string pass = Request.Form["password"];
          
            if (uname == "admin" && pass=="admin")
            {

              
                return View("Dashboard");
            }
            else
            {
               
                return View("Error");
            }
        }
    }
}