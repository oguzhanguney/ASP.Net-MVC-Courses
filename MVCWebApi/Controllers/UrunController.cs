using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApi.Controllers
{
    public class UrunController : ApiController
    {
        private List<Urun> urunlerList = new List<Urun>()
        {
            new Urun{Id=1,Ad="Masaüstü Bilgisayar",Fiyat=3000,KategoriAd="Bilgisayar",StokMiktari=100},
            new Urun{Id=2,Ad="Dizüstü Bilgisayar",Fiyat=2000,KategoriAd="Bilgisayar",StokMiktari=1004},
            new Urun{Id=3,Ad="Cep Telefonu",Fiyat=3000,KategoriAd="Telefon",StokMiktari=100},
            new Urun{Id=4,Ad="Ev Telefonu",Fiyat=3000,KategoriAd="Telefon",StokMiktari=100},

        };
        //şimdi bu listeyi apicontroller içerisinde göstermemiz lazım :
        //metodun başına neden get yazdık.web api yazılım kurallarında eğer değişiklik yapmazsak get işlemi yapan metotların başına get yazmamız lazım böylece get yapıp yapmadıgını program anlasın.
        public IEnumerable<Urun> GetAllUrun()
        {
            return urunlerList;
        }

        //bilinen id ye göre ürün getir:
        //artık url mize /id numaarası verdigimizde o id ye ait ürünü getirecek.
        public IHttpActionResult GetUrun(int id) 
        {
            return Unauthorized();
            var arananUrun = (from u in urunlerList
                              where u.Id == id
                              select u);    //firstordefault sadece ok varken ekliydi.notfound diyebilmemiz için kaldırdık ve ok dönüş tipine yerleştirdik.

            if (arananUrun.Count()==0)
                return NotFound();
            else
            return Ok(arananUrun.FirstOrDefault());
        }

        public IHttpActionResult Post(Urun urun)
        {
            if (urunlerList.Where(u=>u.Id==urun.Id).Count()==0)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }
    }
}
