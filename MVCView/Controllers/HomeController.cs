using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCView.Controllers
{
    public class HomeController : Controller
    {
        //viewlarda tasarımsal olarak aynı bölümlerin birçok sayfada kullanılması gerekebilir.Layout sayesinde tüm viewlarda sabit
        // olan bu bölümleri bir kere oluşturup,degişken yerleri view bazında değiştirebiliriz.sabit yerleri ise layout üzerinden tek bir noktadan
        //degistirdigimizde  bu değişim çalışma anında tüm sayfalarda otomatik olarak saglanacaktır.
        //oluşturacagımız viewi sabit kısımları almak için layoutu bu view e çekerek sabit olan yerleride view da göstermiş olacagız.
        //1-view klasöru altında bir klasör ekleyelim ve adını Shared yapalım.
        //2-içine de layout sayfamızı ekleyelim.


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        //nestedlayoutu kullanan bir view oluşturalim.
        public ActionResult Nested()
        {
            //view i oluştururken ana layoutu degilde nested layoutu seçecegiz.
            return View();
        }

        //Viewstart kavramı:bir layout oluşturmak istedigimizde ve boş bıraktıgımızda direk viewstarttaki layoutun layout olmasını saglayan bir kavram.
        //örnek olarak view altına mvc5 view page ekleyelim
        public ActionResult NewView()
        {
            //viewi oluştururken layout kısmını boş bıraktıgımızda viewstart kullanılacak diyor boş bırakarak ekledik.
            return View();
        }

        //Partial View : Oluşturmamızın en önemli nedenlerinden biri, bir view oluşturuyoruz ve oluşturdugumuz bu view i başka view lerde
        //view olarak kullanabiliyoruz,çekebiliyoruz.Buda bize oluşturdugumuz view da bir degisiklik yapmak istedigimizde başka viewlerdede 
        //otomatik olarak degisikligin görünmesini saglıyor.
        public ActionResult Partial()
        {
            //bu metotu partial yapmak için add view dedigimizde create as a partial view i seçmeliyiz.
            return View();
            //bu partia viewi iletisim hakkımızda ve anasayfa viewlerinde cagıralım.
            //bir kere tanımladık birden fazla viewde kullandık ve bir kere degisiklik yapıp hepsine uyguladık.
        }

    }
}