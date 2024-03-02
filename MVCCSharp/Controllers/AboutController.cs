using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCSharp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}