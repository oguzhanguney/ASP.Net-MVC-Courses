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
        public ActionResult Anasayfa()
        {
            int routeSirasi = this.RouteData.Values.Count - 3;
            string kategori = this.RouteData.Values["kategori" + routeSirasi].ToString();

            ViewBag.KategoriAd = kategori;
            return View();
        }
    }
}