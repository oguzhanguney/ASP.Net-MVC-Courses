using MVCWebHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebHelpers.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrunListesi()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun{ Id=1,Ad="Bilgisayar",Fiyat=2000,Adet=20},
                new Urun{ Id=2,Ad="Masa",Fiyat=500,Adet=620},
                new Urun{ Id=3,Ad="Tv",Fiyat=3000,Adet=120},
                new Urun{ Id=4,Ad="Telefon",Fiyat=1000,Adet=240},
                new Urun{ Id=5,Ad="Kitap",Fiyat=20,Adet=206}

            };
            return View(urunler);
        }


        //ürün ara tanımlayalım.

        public ActionResult UrunAra()
        {
            return View();
        }

        //ürünleri excel e aktarmak için buton işlemlerini yapalım :

        public ActionResult UrunleriExceleAktar()
        {
            return View(Veri.Urunler);
        }

        //excele aktar resultu yapalım:
        public ActionResult ExceleAktar()
        {
            return View(Veri.Urunler);
        }
    }
}