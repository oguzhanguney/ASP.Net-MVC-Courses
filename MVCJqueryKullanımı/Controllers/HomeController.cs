using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJqueryKullanımı.Controllers
{
    public class HomeController : Controller
    {
        // değişken ve fonksiyon tanımlama:
        public ActionResult Index()
        {
            return View();
        }

        //buton click() olayı
        public ActionResult Index2()
        {
            return View();
        }

        //Dizi tanımlama ve each():
        public ActionResult Index3()
        {
            return View();
        }
    }
}