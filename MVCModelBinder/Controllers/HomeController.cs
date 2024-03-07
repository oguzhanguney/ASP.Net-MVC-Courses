using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelBinder.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult YeniUrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrunEkle(string urunAd)
        {   //yeniUrunEkle viewda birden fazla ürün girilebilirdi,bunları name att verdigimiz isimle home controllerda httppost ile yakalayıp
            //metotun içerisinde istedigimiz gibi kullanabiliriz.bu işleme model binder deniyor.
            return View();
        }
    }
}