using MVCModel.Models;
using MVCModel.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Listele()
        {
            //öncelikle yapmamız gereken verilerimizi çekmek.
            //PersonelVeriler içindeki listPersonelleri model nesnemize atayalım.
            //add-view diyerek view i oluşturduk.
            var model = PersonelVeriler.listPersoneller;
            return View(model); //view e modelide gönderdik.
        }
        //modelimizle oluşturdugumuz listemize veri ekleme işlemi yapalım.
        //öncelikle veri ekleyecegimiz bir view oluşturalım.
        [HttpGet]
        public ActionResult VeriEkle()
        {
            //eger böyle oluşturursak controller bize get işlemi yapacagından veri ekleyemeyiz.attribute([httpGet])
            //view oluşturalım.
            return View();
        }
        [HttpPost]
        public ActionResult VeriEkle(Personel personel)
        {
            PersonelVeriler.listPersoneller.Add(personel);

            return RedirectToAction("Listele");
        }

        //Verileri düzenlemek için bir Düzenleme sayfası oluşturalım.

        public ActionResult VeriDuzenle(int id)
        {
            //Listemde seçtigim bir veriyi düzenlemek için listele-view
            //listele-view da her veri için bir düzenle butonu oluşturacagız.
            //düzenle butonunu veridüzenle actiona gönderecegiz.(actionlink-ıd) id degeri gelecegi için parametre olarak int id veriyoruz
            var model=PersonelVeriler.listPersoneller.Where(m=>m.Id==id).FirstOrDefault();
            return View(model);
            //düzenleme işlemi yapıldıktan sonra kaydete bastıgımızda kaydetmesi için post işlemi yapmamız gerekecek
        }
        [HttpPost]
        public ActionResult VeriDuzenle(Personel model)
        {
            //burada aldıgım modeli yeni model ile degistirecegiz.
            //bunun için aldıgımız modelin id sinide tutmamız gerekir.
            var guncellenecek=PersonelVeriler.listPersoneller.Where(m=>m.Id==model.Id).FirstOrDefault();
            guncellenecek.Ad = model.Ad;
            guncellenecek.Soyad=model.Soyad;
            guncellenecek.TCKN=model.TCKN;
            guncellenecek.DogumTarihi=model.DogumTarihi;

            return RedirectToAction("Listele");
        }

        //Verileri silmek için bir VeriSil sayfası oluşturalım
        public ActionResult VeriSil(int id)
        {
            var silinecek=PersonelVeriler.listPersoneller.Where(m=>m.Id==id).FirstOrDefault();
            PersonelVeriler.listPersoneller.Remove(silinecek);
            return RedirectToAction("Listele");
        }
    }
}