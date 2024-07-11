using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranDuyVu_2210900138.Controllers
{
    public class TDVHomeController : Controller
    {
        public ActionResult TdvIndex()
        {
            return View();
        }

        public ActionResult TdvAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TdvContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}