using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionAttribute.Controllers
{
    public class OnBellekController : Controller
    {
        //saati gösterme işlemlerini yapacagız.saat olaylarını gösterecegiz.biz yeniledigimizde şuanki saaat neyse onu getirecek.
        //Onbellek:
        [OutputCache(Duration = 60)]//60 saniye önbellekte tutmasını istedik.artık sayfayı her yeniledigimizde saaati güncellemeyecek 60 saniye boyunca önbellekteki saati verecek.
        public ActionResult SaatGoster()
        {
            //saati göstermek için bizim bir viewbag saat göstergesine ihtiyacımız var.
            ViewBag.Saat=string.Format("{0:dd.MM.yyyy HH:mm:ss}",DateTime.Now);
            //şimdi viewbag saat nesnemizi view de göstererek işlemlerimizi yapabiliriz.addview

            return View();
        }
    }
}