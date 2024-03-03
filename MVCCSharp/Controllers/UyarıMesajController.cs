using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCSharp.Controllers
{
    public class UyarıMesajController : Controller
    {
        // GET: UyarıMesaj
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sayfa() //Yönlendirme sayfamızı oluşturma:
        {
            return View();
        }
    }
}