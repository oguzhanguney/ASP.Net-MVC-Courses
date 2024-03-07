using MVCAttribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAttribute.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult YeniVeriEkle()
        {
            //viewi oluştururken  modele veri ekleme işlemi yapacagımız için view-template i create olarak seçelim
            return View();
        }
        [HttpPost]
        public ActionResult YeniVeriEkle(Uye uye)
        {
            return View();
        }
        //
        private static Uye uye = new Uye()
        {
            Id = 1,
            Ad = "Ali Osman",
            Soyad = "Hazır",
            TCKimlikNo = "11111111111",
            UyelikTarihi = new DateTime(2017, 12, 09)
        };
        public ActionResult Detay()
        {
            return View(uye);
        }
    }
}