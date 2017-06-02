using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PL1;
using PL1.Models;

namespace PL1.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (!MyFunctions.CheckUserRole(User.Identity.Name, "man"))
            {
                return RedirectToAction("Index", "Warning", new { id = "601" });
            }

            return View();
        }
    }
}