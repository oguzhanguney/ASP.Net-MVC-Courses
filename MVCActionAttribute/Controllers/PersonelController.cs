using MVCActionAttribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Controllers
{
    public class PersonelController : Controller
    {
        //buraya bir personel listesi oluşturmamız lazım.ve bu listesini sayfalar arası geçişte kaybolmamasını istedigimiz için static yapmalıyız.

        private static List<Personel> PersonellerList = new List<Personel>()
        {
            new Personel{Id=1,Ad="Oguzhan",Soyad="Güney",TCKN="111"},
            new Personel{Id=2,Ad="İrfan",Soyad="Canpolat",TCKN="222"},
            new Personel{Id=3,Ad="Harun",Soyad="Güneş",TCKN="333"},
            new Personel{Id=4,Ad="Alican",Soyad="Sarıbpğa",TCKN="444"},

        };

        //sayfamızı oluşturalım
         public ActionResult Personeller()
        {
            return View(PersonellerList);
        }

        //HttpPost:
        //silme işlemi:tekrar sayfaya dönderen bir action olacagı için RedirectToRouteResult
        [HttpPost]
        public RedirectToRouteResult Sil(int id)
        {
            var silinecek=PersonellerList.Where(p=> p.Id==id).FirstOrDefault();
            PersonellerList.Remove(silinecek);

            return new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Action = "Personeller", Controller="Personel" }));
        }

        //httpget
        public ActionResult PersonelAra()
        {
            return View();
        }
        [HttpGet]
        public ActionResult PersonelAramaSonucu(string personelAra)
        {
            ViewBag.ArananKelime=personelAra;
            var sonuc=PersonellerList.Where(p=>p.Ad.Contains(personelAra)).ToList();
            return View(sonuc);
        }

        //Bind attributes:
        public ActionResult YeniPersonel()
        {
            return View();
        }
        //yenipersonel view de create dedigimizde gönderme işlemi olacak ve post ile bunu yakalayalım.
        [HttpPost]
        public ActionResult YeniPersonel(Personel per)
        { //hiçbir kontrol yapmadan bilgileri dogrudan getirdi.şimdi bind ile bir kontrol saglayalım.personel class a gidelim.ve sadece ad soyadın gelmesini saglayalım.artık tc yi null olarak gördük
            return View();
        }

    }
}