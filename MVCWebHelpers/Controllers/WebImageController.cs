using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVCWebHelpers.Controllers
{
    public class WebImageController : Controller
    {
        // GET: WebImage
        public ActionResult Index()
        {
            return View();
        }

        //web image resim yolu
        private string ResimYolu
        {
            get
            {
                return Server.MapPath("~/Content/Image.png");
            }
        }

        //resmi görüntülemek için
        public void ResimGoruntule()
        {
            WebImage resim=new WebImage(ResimYolu);
            resim.Write();
        }

        //resmi döndürmek için:
        public void ResimDonder()
        {
            WebImage resim = new WebImage(ResimYolu);
            //resim.RotateRight();//sola döndermek için left
            //resim.FlipVertical();//yatay bir çizgi etrafında çevirme
            resim.FlipHorizontal();//dikey bir çizgi etrafında çevirme
            resim.Write();
        }

        //resim boyutlandırma
        public void ResmiBoyutlandır()
        {
            WebImage resim = new WebImage(ResimYolu);
            resim.Resize(100,100,preserveAspectRatio:true);//preserveAspectRatio : oranları koruyup korumamıza karar verir.
            resim.Write();
        }

        //resim kesme işlemi:
        public void ResmiKes()
        {
            WebImage resim = new WebImage(ResimYolu);
            resim.Crop(top: 180, left: 10, bottom: 60, right: 10);
            resim.Write();
        }

        //resme yazı ekleme işlemi:
        public void ResmeYaziEkleme()
        {
            WebImage resim = new WebImage(ResimYolu);
            resim.AddTextWatermark("OG Software", fontColor: "red", fontSize: 20 );
            resim.Write();
        }

        //resme yazı ekleme işlemi:
        public void ResmeResimEkleme()
        {
            WebImage resim = new WebImage(ResimYolu);
            resim.AddImageWatermark(Server.MapPath("~/Content/Image2.png"));
            resim.Write();
        }
    }
}