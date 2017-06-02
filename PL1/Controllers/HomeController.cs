using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int thisYear = DateTime.Now.Year;
            int nextYear = thisYear + 1;
            ViewBag.PosMessage = thisYear.ToString() + "-" + nextYear.ToString() + " Program of Studies";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome..";
            ViewBag.HakanAbiEmail = "h.aras@vistula.edu.pl.";

            return View();
        }
    }
}