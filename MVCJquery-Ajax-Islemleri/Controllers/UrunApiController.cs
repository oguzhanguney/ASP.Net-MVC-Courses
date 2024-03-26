using MVCJquery_Ajax_Islemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCJquery_Ajax_Islemleri.Controllers
{
    public class UrunApiController : ApiController
    {
        [HttpGet]
        public Urun Urun()
        {
            var urun=(from u in Veri.Urunler
                      where u.Id==1
                      select u).FirstOrDefault();
            return urun;
            //şimdi web api route ayarlarını yapalım.
        }

        [HttpPost]
        public void Kaydet(Urun yeniUrun)
        {
            Veri.Urunler.Add(yeniUrun);
            //ürünü eklemek için Urun controller a bir action tanımlayalım.

        }
    }
}
