using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDers_001.Controllers
{
    public class OguzhanController : Controller
    {
        // GET: Oguzhan
        //üstüne birşey yazılmadıgı  zaman  get işlemi yapar.Kullanıcıya viewi gönderme işlemi.
        public ActionResult Index()
        {
            return View();
        }
    }
}