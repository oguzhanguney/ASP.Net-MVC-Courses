using MVCOgrenciBilgiSistemi_Controller.DAL;
using MVCOgrenciBilgiSistemi_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

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
        public RedirectToRouteResult Ekle(Fakulte kayit)
        {
            //kaydı veritabanına eklememiz lazım bunun içinde:
            veritabani.Fakulteler.Add(kayit);
            veritabani.SaveChanges();
            return new RedirectToRouteResult(new RouteValueDictionary(new {Action="Ekle", controller="Fakulte"}));
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

        //partial view result lesson :dropdown list
        public ActionResult Fakulteler()
        {
            //bu action result bize bir dropdown list dönmesi için viewbag imizde fakulteleri tutacak bir dropdown list elemanı olması lazım :
            var fakulteler=veritabani.Fakulteler.ToList().Select(f=>new SelectListItem
            {
                Selected=false,
                Text=f.FakulteAd,
                Value=f.Id.ToString()
            }).ToList();
            ViewBag.Fakulteler= fakulteler;
            return View();
            //view ekleyelim.
        }


        //actionname: action metodununun oluşturuldugundan farklı bir isimde çağrılması gerektıgı durumlarda bu attribute ile action metodu parametrede tanımlanan isimle çağrılabilir
        //yani birden fazla aynı isimli ve farklı parametrelere sahip action varsa bu actionları actionname ile farklı isimlendirme yapabiliriz.
        //tüm fakultelerin detayını bir action da , fakulte ıd sine göre fakulte detayını farklı bir actionda tanımlayacagızz.
        //
        [ActionName("TumFakulteler")]
        public ActionResult Detay()
        {
            return View();
        }
        [ActionName("Fakulte")]
        public ActionResult Detay(int id)
        {
            ViewBag.FakulteId=id;
            return View();
        }

    }
}