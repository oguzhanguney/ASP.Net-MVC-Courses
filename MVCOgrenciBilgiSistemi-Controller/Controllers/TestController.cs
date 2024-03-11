using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi_Controller.Controllers
{
    public class TestController : Controller
    {
        //bir javascript türünde metot yazdıgımızda  return un javascript olması lazım.
        public JavaScriptResult MesajGoster()
        {
            string script = "alert('butona tıklandı.Veri actiondan alındı')";

            return JavaScript(script);//içerisine string türünde bir script istiyor.
        }
        //şimdi bir başka view da bu metodu çağıralım

        public ActionResult TestJS()
        {
            return View();
        }
       
    }
}