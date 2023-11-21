using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.db;

namespace Zero_Hunger.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        Zero_HungerEntities dbObj = new Zero_HungerEntities();

        
        public ActionResult Indexe()
        {
            return View();
        }


        public ActionResult Signupe()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signupe(dbEMPLOYEE_List model)
        {
            if (dbObj.dbEMPLOYEE_List.Any(x => x.EMPLOYEE_NAME == model.EMPLOYEE_NAME))
            {
                ViewBag.Notification = "This acount has already existed";
                return View();
            }


            else
            {

                if (ModelState.IsValid)
                {
                    dbEMPLOYEE_List obj = new dbEMPLOYEE_List();

                    obj.EMPLOYEE_NAME = model.EMPLOYEE_NAME;
                    obj.password = model.password;


                    dbObj.dbEMPLOYEE_List.Add(obj);
                    dbObj.SaveChanges();

                    Session["EMPLOYYE_ID"] = obj.EMPLOYYE_ID.ToString();
                    Session["EMPLOYEE_NAME"] = obj.EMPLOYEE_NAME.ToString();



                }
                ViewBag.Notification = "Account Created Successful";
                return RedirectToAction("Indexe", "Employee");
            }



        }

        public ActionResult Logoute()
        {
            Session.Clear();
            return RedirectToAction("Signupe", "Employee");
        }

        [HttpGet]
        public ActionResult Logine()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logine(dbEMPLOYEE_List model)
        {
            //dbEmployee_List obj = new dbEmployee_List();
            var checkLogine = dbObj.dbEMPLOYEE_List.Where(x => x.EMPLOYEE_NAME.Equals(model.EMPLOYEE_NAME) && x.password.Equals(model.password)).FirstOrDefault();
            if (checkLogine != null)
            {

                Session["EMPLOYYE_ID"] = model.EMPLOYYE_ID.ToString();
                Session["EMPLOYEE_NAME"] = model.EMPLOYEE_NAME.ToString();
                return RedirectToAction("Indexe", "Employee");
            }
            else
            {
                ViewBag.Notification = "Wrong Username or password";
            }
            return View();
        }
    }
}