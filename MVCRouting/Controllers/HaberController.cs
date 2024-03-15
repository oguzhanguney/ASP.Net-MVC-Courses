using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouting.Controllers
{
    public class HaberController : Controller
    {
        // GET: Haber
        public ActionResult Detay(string haber)
        {
            ViewBag.HaberAd = haber.Replace('-',' ');

            return View();
        }
    }
}