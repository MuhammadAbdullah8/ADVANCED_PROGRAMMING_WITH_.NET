using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.db;

namespace Zero_Hunger.Controllers
{
    public class RestaurentController : Controller
    {
        // GET: Restaurent
        Zero_HungerEntities dbObj = new Zero_HungerEntities();


        public ActionResult Indexr()
        {
            return View();
        }


        public ActionResult Signupr()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signupr(dbRESTAURENT_List model)
        {
            if (dbObj.dbRESTAURENT_List.Any(x => x.RESTAURENT_NAME == model.RESTAURENT_NAME))
            {
                ViewBag.Notification = "This acount has already existed";
                return View();
            }


            else
            {

                if (ModelState.IsValid)
                {
                    dbRESTAURENT_List obj = new dbRESTAURENT_List();

                    obj.RESTAURENT_NAME = model.RESTAURENT_NAME;
                    obj.password = model.password;


                    dbObj.dbRESTAURENT_List.Add(obj);
                    dbObj.SaveChanges();

                    Session["RESTAURENT_ID"] = obj.RESTAURENT_ID.ToString();
                    Session["RESTAURENT_NAME"] = obj.RESTAURENT_NAME.ToString();



                }
                ViewBag.Notification = "Account Created Successful";
                return RedirectToAction("Indexr", "Restaurent");
            }



        }

        public ActionResult Logoutr()
        {
            Session.Clear();
            return RedirectToAction("Signupr", "Restaurent");
        }

        [HttpGet]
        public ActionResult Loginr()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(dbRESTAURENT_List model)
        {
            //dbNGO_List obj = new dbNGO_List();
            var checkLogin = dbObj.dbRESTAURENT_List.Where(x => x.RESTAURENT_NAME.Equals(model.RESTAURENT_NAME) && x.password.Equals(model.password)).FirstOrDefault();
            if (checkLogin != null)
            {

                Session["RESTAURENT_ID"] = model.RESTAURENT_ID.ToString();
                Session["RESTAURENT_NAME"] = model.RESTAURENT_NAME.ToString();
                return RedirectToAction("Indexr", "Restaurent");
            }
            else
            {
                ViewBag.Notification = "Wrong Username or password";
            }
            return View();
        }


    }
}