using MVCOgrenciBilgiSistemi_Controller.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi_Controller.Controllers
{
    public class BolumController : Controller
    {
        //öncelikle veritabanı nesnemizi oluşturalım.
        OBSContext veritabani = new OBSContext();

        // GET: Bolum
        public ActionResult Index()
        {
            return View();
        }

        //partial view metodu:
        public PartialViewResult FakultedekiBolumler(int? id)//hangi fakultedeki bölümler olacagini belirtmek için id parameter (? boş geçilebilir-hata)
        {
            if (id == null) id = 1;

            //şimdi id sini bildigimiz bir fakültenin bölümlerini getirmemiz lazım
            var bolumler=(from b in veritabani.Bolumler where b.FakulteId==id select b).ToList();
            //bu bir model oldugu için :
            ViewBag.Bolumler = bolumler;
            //viewi oluşturalım. template=list model=bolum create partial view 

            return PartialView();
        }
    }
}