using IntroandForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IntroandForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        //public ActionResult Login(FormCollection fc) {
        //public ActionResult Login(string Password,string Username) {
        public ActionResult Login(Login l)
        {
            //ViewBag.Uname = Request["Username"];
            //ViewBag.Pass = Request["Password"];
            //ViewBag.Uname = fc["Username"];
            //ViewBag.Pass = fc["Password"];
            //ViewBag.Uname = Username;
            //ViewBag.Pass = Password;

            return View(l);
        }
        public ActionResult LoginSubmit()
        {
            //validation
            //authentication
            TempData["msg"] = "Login Successfull";
            //return Redirect("https://www.aiub.edu");
            return RedirectToAction("Index", "Dashboard");

        }



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
