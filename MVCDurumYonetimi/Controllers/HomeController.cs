using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDurumYonetimi.Controllers
{
    public class HomeController : Controller
    {
        // Session State
        public ActionResult Index()
        {
            Session.Add("egitmen", "Oguzhan Guney");
            Session.Add("sayi", 5);
            Session["egitmen2"] = "Alican Sarıboga";//bir diger session oluşturma yöntemi.

            ViewBag.message = Session["egitmen"];

            Session.Remove("egitmen2");//session silme işlemi

            Session.Abandon();//bütün oturumların kapatılmasını sağlar.tüm sessionları sonlandırmış oluruz.kullanıcılar log out oldugu zaman kullanabiliriz.

            ViewBag.Online = HttpContext.Application["OnlineUyeSayisi"];

            return View();

        }

        //application state:
        public ActionResult Index2()
        {
            //bir application nesnesi oluşturalım.
            HttpContext.Application.Add("egitmen", "Oguzhan Guney");
            HttpContext.Application["egitmen2"] = "Alican Sarıboga";

            //okuma işlemi 
            ViewBag.Message = HttpContext.Application["egitmen"];
            //silme işlemş
            HttpContext.Application.Remove("egitmen2");

            HttpContext.Application.RemoveAll();//bütün oluşmuş application nesnelerini silebiliriz.
            return View();
        }

        //Cookie(çerezler)
        public ActionResult Cookie()
        {
            //bir cookie nesnesi oluşturalım.
            HttpCookie cooki = new HttpCookie("kullanici", "Oguzhan ");   
            HttpContext.Response.Cookies.Add(cooki);//cookie olarak varlıgını devam ettirebilmesi için:
            //cookiler için yaşam süresi varsayılan olarak 30 dk.yaşam süresini ayarlamak için 
            cooki.Expires=DateTime.Now.AddDays(1);
            //okumak için:
            ViewBag.Message = HttpContext.Response.Cookies["kullanici"].Value;

            //silmek için:
            HttpContext.Response.Cookies.Remove("kullanici");
            //cookiler için yaşam süresi varsayılan olarak 30 dk.yaşam süresini ayarlamak için 

            return View();
        }


    }
}