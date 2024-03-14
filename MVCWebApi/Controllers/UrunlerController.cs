using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApi.Controllers
{
    public class UrunlerController : Controller
    {
        //burada bütün ürünleri gösterecek bir özellik yapmak istedigimiz için:

        public ActionResult TumUrunler()
        {
            //boş bir view oluşturalım ve layout kullanalım.çünkü işlemlerimizi jquery ile yapacagız.jquery ile apideki verilere erişmeye calısacagız.
            return View();
        }

        //id sini bildigimiz ürünü getirmek için:

        public ActionResult UrunGetir()
        {
            //viewini oluşturalım.jquery ile işlemlerimizi yapalım.
            return View();
        }

        //apiye ürün girecegiz.
        public ActionResult YeniUrun()
        {
            return View();
        }
    }
}