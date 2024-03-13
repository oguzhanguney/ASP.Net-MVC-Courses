using MVC.Grid.Models;
using MVC.Grid.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Grid.Controllers
{
    public class GridController : Controller
    {
        //database ile ilgili işlemler yapacagımız için veritabanı nesnemizi oluşturalım.
        DatabaseContext db=new DatabaseContext();


        // GET: Grid
        public ActionResult Index()
        {
            return View();
        }

        //listele actionu oluşturalım.

        public ActionResult Listele()
        {
            var model=db.Personeller.ToList();
            return View(model);
        }

        //ekleme işlemi için
        public ActionResult Ekle()
        {
            List<SelectListItem> ulkeler=
                (from i in db.Ulkeler.ToList()
                 select new SelectListItem
                 {
                     Text=i.Ad,
                     Value=i.Id.ToString()
                 }).ToList();
            ViewBag.Ulkeler = ulkeler;
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Personel model)
        {
            var ulke=db.Ulkeler.Where(m=>m.Id==model.Ulke.Id).FirstOrDefault();
            model.Ulke = ulke;
            db.Personeller.Add(model);
            db.SaveChanges();

            return RedirectToAction("Listele");
        }

        //düzenleme işlemi için:
        public ActionResult Duzenle(int id)
        {
            var personel=db.Personeller.Where(m=>m.Id==id).FirstOrDefault();
            List<SelectListItem> ulkeler =
                (from i in db.Ulkeler.ToList()
                 select new SelectListItem
                 {
                     Text = i.Ad,
                     Value = i.Id.ToString()
                 }).ToList();
            ViewBag.Ulkeler = ulkeler;

            return View(personel);
        }
        [HttpPost]
        public ActionResult Duzenle(Personel model)
        {
            var personel=db.Personeller.Where(m=>m.Id==model.Id).FirstOrDefault();
            personel.Ad = model.Ad;
            personel.Soyad = model.Soyad;
            personel.Yas = model.Yas;

            var ulke = db.Ulkeler.Where(m => m.Id == model.Ulke.Id).FirstOrDefault();
            personel.Ulke = ulke;
            db.SaveChanges();
            return RedirectToAction("Listele");

        }

        //silme işlemi:
        public ActionResult Sil(int? id)
        {
            if (id != null)
            {
                var personel=db.Personeller.Where(m=>m.Id == id).FirstOrDefault();
                if (personel !=null)
                {
                    db.Personeller.Remove(personel);
                    int deger=db.SaveChanges();
                    if (deger>0)
                    {
                        //veritabanı etkilendi.
                    }
                    else
                    {
                        //veritabanı etkilenmedi.
                    }
                }
            }

            return View();
        }
    }
}