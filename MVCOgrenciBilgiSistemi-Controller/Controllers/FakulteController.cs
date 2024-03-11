using MVCOgrenciBilgiSistemi_Controller.DAL;
using MVCOgrenciBilgiSistemi_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi_Controller.Controllers
{
    public class FakulteController : Controller
    {

        OBSContext veritabani=new OBSContext();

        // GET: Fakulte
        public ActionResult Index()
        {
            return View();
        }

        //RedirectResult =bu bir geri dönüş türüdür.bize bir return Redirect diyerek string olarak bir url istiyor(bir başka web sayfasına yönlendirme işlemi).

        public ActionResult Ekle()
        {
            //Addview-Create template-Model fakulte-datacontext obscontext
            return View();
            //ekle view da create butona tıkladıktan sonra model döndürecek bir view oluştu.
        }
        //Model döndüreceginden dolayı redirecttoactıon:
        [HttpPost]
        public RedirectResult Ekle(Fakulte kayit)
        {
            //kaydı veritabanına eklememiz lazım bunun içinde:
            veritabani.Fakulteler.Add(kayit);
            veritabani.SaveChanges();
            return Redirect("https://www.youtube.com/channel/UCabuPeggpkGAuoPB74jfogg");
        }

        //Json Result:
        //butona tıklandıgında  verilerimin jsona dönmesini  istiyorum.jquery ajax oluşturulmuş bir buton:(post)
        [HttpPost]
        public JsonResult Listele()
        {
            var fakulteler=veritabani.Fakulteler.ToList();
            return Json(fakulteler);
        }
        //şimdi bir butona tıklandıktan sonra jquery ajax ile işlemleri yapacagımız view için action oluşturalım.
        public ActionResult FakultelerJson()
        {
            return View();
        }
    }
}