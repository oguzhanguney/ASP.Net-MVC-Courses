using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Controllers
{
    public class OnlineIslemlerController : Controller
    {
        //şimdi buraya sadece debug ve release modda çalış özellikleri ekleyelim. ve debug mod olmadıgı zaman çalış debug moddayken [RequireHttps] bu att okunmasın.
#if !DEBUG
        [RequireHttps] //debug modda oldugumuz için calısmaz.(bilgisayarda https ayarları kapalıysa)
#endif
        public ActionResult Giris()
        {
            return View();
        }
    }
}