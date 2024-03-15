using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouting.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult ArsivTarih(string tarih)
        {
            return View();
        }
    }
}