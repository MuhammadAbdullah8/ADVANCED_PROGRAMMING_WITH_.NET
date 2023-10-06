using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Education Info.";

            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Project Info.";

            return View();
        }

        public ActionResult Personalinfo()
        {
            ViewBag.Message = "Personal Info.";

            return View();
        }


    }
}