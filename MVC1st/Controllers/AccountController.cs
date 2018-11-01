using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// add by AWR
using MVC1st.Models;


namespace MVC1st.Controllers
{
    /// <summary>
    /// Code First: https://www.youtube.com/watch?v=Uq0y8oxnx-8
    /// </summary>
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (awrDBContext db = new awrDBContext())
            {
                return View(db.userAccount.ToList());
            }
              
        }

        public ActionResult UserRegistrationDB()
        {// https://www.youtube.com/watch?v=Uq0y8oxnx-8

            return View();
        }

        [HttpPost]
        public ActionResult UserRegistrationDB(UserAccount userAccount)
        {// https://www.youtube.com/watch?v=Uq0y8oxnx-8

            if (ModelState.IsValid)
            {
                using (awrDBContext db = new awrDBContext()) {
                    db.userAccount.Add(userAccount);
                    db.SaveChanges();

                }
                ModelState.Clear();
                ViewBag.Message = userAccount.UserLogin + " is successfully registaration.";
            }
            return View();
        }


        // Login Method
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount userAccount)
        {
            using (awrDBContext db = new awrDBContext())
            {
                var user = db.userAccount.Single(u => u.UserLogin == userAccount.UserLogin &&
                                                    u.UserPassword == userAccount.UserPassword);
                if (user != null)
                {
                    Session["UserID"] = user.UserID.ToString();
                    Session["UserLogin"] = user.UserLogin.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else {
                    ModelState.AddModelError("", "Login od Password is wrong.");
                }
            }
            return View();
        }


        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        
        }

    }
}