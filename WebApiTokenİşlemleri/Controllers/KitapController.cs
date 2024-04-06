using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTokenİşlemleri.Models;

namespace WebApiTokenİşlemleri.Controllers
{
    [Authorize]//token oldugu için attr ekledik.
    public class KitapController : ApiController
    {
        //database
        private KutuphaneServis db= new KutuphaneServis();

        [HttpGet]
        public IQueryable<Kitap> GetKitaps()
        {
            return db.Kitaplar;
        }

        [HttpPost]
        public IHttpActionResult KitapEkle(Kitap entity)
        {
            db.Kitaplar.Add(entity);
            db.SaveChanges();
            return Json("Post İşlemi Başarılı");
        }

        [HttpPut]
        public IHttpActionResult KitapGuncelle(Kitap entity)
        {
            db.Entry(entity).State=System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json("Güncelleme Başarılı");
        }

        [HttpDelete]
        public IHttpActionResult KitapSil(int Id) 
        { 
            var silinecek=db.Kitaplar.FirstOrDefault(x => x.Id==Id);
            db.Kitaplar.Remove(silinecek);
            db.SaveChanges();
            return Json("Silme Başarılı");
        }
    }
}
