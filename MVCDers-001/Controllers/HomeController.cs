using MVCDers_001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDers_001.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Personel per = new Personel();
            per.Id = 1;
            per.Ad = "Oğuzhan";
            per.Soyad = "Güney";

            return View(per);
        }
    }
}