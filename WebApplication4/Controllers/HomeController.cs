using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Code1()
        {
            ViewData["message"] = "ViewData message here";
            ViewData["currenttime"] = DateTime.Now;
            return View();

        }

        public ActionResult Code2()
        {
            ViewBag.message = "ViewBag message here";
            ViewBag.currenttime = DateTime.Now;
            return View();
        }

        public ActionResult Code3()
        {
            ViewBag.something = "message here";
            return View();

        }

        public ActionResult Code4()
        {
            TempData["tempmsg"] = "Temp Message";
            return Redirect("Code4b");
        }
        
        public ActionResult Code4b()
        {
            return View();

        }

        public ActionResult Code5()
        {
            return View();
        }

        public ActionResult Code6()
        {
            return View();
        }

        public ActionResult Code7()
        {
            return View();
        }

        public ActionResult Code8()
        {
            return View();
        }

        public ActionResult Code9()
        {
            return View();
        }

        public ActionResult Code10()
        {
            return View();
        }

        public ActionResult Code11()
        {
            return View();
        }
	}
}