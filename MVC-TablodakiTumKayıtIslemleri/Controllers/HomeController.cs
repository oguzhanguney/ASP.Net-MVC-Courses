using MVC_TablodakiTumKayıtIslemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TablodakiTumKayıtIslemleri.Controllers
{
    public class HomeController : Controller
    {
        //Kayıtları Seçme:
        public ActionResult TumKayitlariSec()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun
                {
                    Id = 1,
                    Ad="Tablet",
                    Fiyat=3000
                },
                new Urun
                {
                    Id = 2,
                    Ad="Bilgisayar",
                    Fiyat=5000
                },
                new Urun
                {
                    Id = 3,
                    Ad="Telefon",
                    Fiyat=1000
                },
                new Urun
                {
                    Id= 4,
                    Ad="Tv",
                    Fiyat=4000
                }
            };
            ViewBag.Urunler = urunler;
            return View();
        }

        //Seçili kayıtları silme:
        [HttpPost]
        public ActionResult SeciliUrunleriSil(string seciliIdler)
        {
            return View();
        }
    }
}