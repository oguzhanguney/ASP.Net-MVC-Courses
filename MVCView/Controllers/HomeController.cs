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
    }
}