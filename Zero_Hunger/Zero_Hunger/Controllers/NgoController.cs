using Zero_Hunger.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zero_Hunger.Controllers
{
    public class NgoController : Controller
    {
        Zero_HungerEntities dbObj = new Zero_HungerEntities();

        // GET: Ngo

        //public ActionResult Index()
        //{
        //    return View();
        //}


        public ActionResult Index()
        {
            Zero_HungerEntities requestDB = new Zero_HungerEntities();
            var request = requestDB.dbTRACKCOLLECTION_List;
            return View(request);
        }

        [HttpGet]
        public ActionResult PendingRequest()
        {
            Zero_HungerEntities requestDB = new Zero_HungerEntities();
            var request = (from req in requestDB.dbTRACKCOLLECTION_List
                           where req.STATUS.Equals("Pending")
                           select req);
            return View(request);
        }

        [HttpPost]
        public ActionResult PendingRequest(dbTRACKCOLLECTION_List model)
        {
            var requestDB = new Zero_HungerEntities();
            var request = (from r in requestDB.dbTRACKCOLLECTION_List
                           where r.COLLECTREQUEST_ID.Equals(model.COLLECTREQUEST_ID)
                           select r).SingleOrDefault();
            if (request != null)
            {
                requestDB.Entry(request).CurrentValues.SetValues(model);
                requestDB.SaveChanges();
                return RedirectToAction("PendingRequest", "Ngo");
            }

            TempData["Msg"] = "Employee ID Invalid";
            return RedirectToAction("PendingRequest", "Ngo");
        }






        public ActionResult Signup()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Signup(dbNGO_List model)
        {
            if (dbObj.dbNGO_List.Any(x => x.NGO_NAME == model.NGO_NAME))
            {
                ViewBag.Notification = "This acount has already existed";
                return View();
            }


            else
            {

                if (ModelState.IsValid)
                {
                    dbNGO_List obj = new dbNGO_List();

                    obj.NGO_NAME = model.NGO_NAME;
                    obj.password = model.password;


                    dbObj.dbNGO_List.Add(obj);
                    dbObj.SaveChanges();

                    Session["NGO_ID"] = obj.NGO_ID.ToString();
                    Session["NGO_NAME"] = obj.NGO_NAME.ToString();


                    
                }
                ViewBag.Notification = "Account Created Successful";
                return RedirectToAction("Index", "Ngo");
            }
            
            
           
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("LandingPage", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(dbNGO_List model)
        {
            //dbNGO_List obj = new dbNGO_List();
            var checkLogin = dbObj.dbNGO_List.Where(x => x.NGO_NAME.Equals(model.NGO_NAME) && x.password.Equals(model.password)).FirstOrDefault();
            if (checkLogin != null)
            {

                Session["NGO_ID"] = model.NGO_ID.ToString();
                Session["NGO_NAME"] = model.NGO_NAME.ToString();
                return RedirectToAction("Index", "Ngo");
            }
            else 
            {
                ViewBag.Notification = "Wrong Username or password";
            }
            return View();
        }



    }
}