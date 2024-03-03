using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelPartial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Listele()
        {
            if (TempData["degerler"]==null)
            {
                ViewBag.Degerler = new List<int>();
            }
            else
            {
                ViewBag.Degerler = TempData["degerler"];

            }

            return View();
        }
        public ActionResult Doldur()
        {
            List<int> listDegerler=new List<int>();
            listDegerler.Add(2);
            listDegerler.Add(45);
            listDegerler.Add(234);
            listDegerler.Add(12);
            listDegerler.Add(89);

            TempData["degerler"]=listDegerler;
            return RedirectToAction("Listele");

        }
    }
}