using FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        [HttpGet]
        public ActionResult Signup()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Signup(Signup s)
        {

            return View(s);
        }
        public ActionResult SignupSubmit()
        {


            TempData["msg"] = "Signup Successfull";

            return RedirectToAction("Index", "Dashboard");

        }






    }
}