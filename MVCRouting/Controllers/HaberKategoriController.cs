using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRouting.Controllers
{
    public class HaberKategoriController : Controller
    {
        // GET: HaberKategori
        public ActionResult Anasayfaa(string kategori)
        {
            

            ViewBag.KategoriAd = kategori;
            return View();
        }
    }
}