using MVCFiltreler.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltreler.Controllers
{
    public class HataController : Controller
    {
        // GET: Hata
        [HandleError(ExceptionType = typeof(FormatException),View ="Hata")]
        [Log]
        public ActionResult Index()
        {
            //hataları yakalamak için metotun içerisine hata yakalama kodunu yazalım.

            throw new FormatException(); // bu satırda hata yakalayacak ve devam ettirdigimizde satır satır kodlarımız görünecek.
                                         //bu güzel bir görüntü olmadıgı için bizim hatayla karşılacagımızda shared klasörü altında açılabilecek hata sayfamız bulunmakta.

        }
    }
}