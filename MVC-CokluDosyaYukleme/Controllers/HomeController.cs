using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CokluDosyaYukleme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Dosya yükleme:
        public ActionResult DosyaYukleme()
        {
            return View();
        }

        //Butona tıklandıgınca postback için(tekli dosya yükleme):
        [HttpPost]
        public ActionResult TekliDosyaYukleme(HttpPostedFileBase dosya)
        {
            if (dosya != null)
            {
                string dosyaYolu=Path.GetFileName(dosya.FileName);
                var yuklemeYeri = Path.Combine(Server.MapPath("~/Dosyalar"),dosyaYolu);
                dosya.SaveAs(yuklemeYeri);
            }
            return View();
        }

        //coklu dosya yükleme:
        [HttpPost]
        public ActionResult CokluDosyaYukleme(IEnumerable<HttpPostedFileBase> dosyalar)
        {
            foreach (var dosya in dosyalar)
            {
                if (dosya != null)
                {
                    string dosyaYolu = Path.GetFileName(dosya.FileName);
                    var yuklemeYeri = Path.Combine(Server.MapPath("~/Dosyalar"), dosyaYolu);
                    dosya.SaveAs(yuklemeYeri);
                }
            }
            return View();


        }
    }
}