using MVCFiltreler.Filters;
using MVCFiltreler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltreler.Controllers
{
    //[Log] //controllera log alınca içindeki tüm actionların logunu almış olacagız.
    public class HomeController : Controller
    {
        [Log] // actionlara log almak için --result filter için burayı çalıştıralım
        public ActionResult Index()
        {
            return View();
        }
        [Log]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Log]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //aldıgımız logları bir action ile ekranda gösterelim.
        public ActionResult LogKayıtları()
        {
            return View(LogVerileri.Loglar);
        }
    }
}