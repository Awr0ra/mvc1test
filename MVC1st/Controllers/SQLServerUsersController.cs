using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1st.Models;


namespace MVC1st.Controllers
{
    public class SQLServerUsersController : Controller
    {
        // GET: SQLServerUsers
        public ActionResult Index()
        {
            using (SQLServerDBContext db = new SQLServerDBContext())
            {
                return View(db.SQLServerUserAccounts.ToList());
            }

        }



    }
}