using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRouting
{
    public class RouteConfig
    {
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //    routes.MapRoute(
        //        name: "Default",
        //        url: "{controller}/{action}/{id}",
        //        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        //    );
        //}

        //Haber Sitesi Route:
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Anasayfa",
                url: "anasayfa",//tek bir sayfadan oluşacagı için direk anasayfa diyelim.sabir bir link vermiş olduk.
                defaults: new { controller = "Site", action = "Anasayfa" }
            );


            //Kategori Route:

            int kirilimSayisi = 3; //veri tabanından sorgu yaptık kırılım sayımızı max olarak 3 bulduk ve getirdik 
            string kategoriUrl = "kategori";
            //şimdi bir for döngüsü ile kategori url sini hazırlayalım .kırılım sayısına göre bu url değişkenlik gösterecek.

            for (int i = 0; i < kirilimSayisi; i++)
            {
                kategoriUrl += "/{kategori" + i + "}";

                routes.MapRoute(
                name: "Kategori"+i,
                url: kategoriUrl,
                defaults: new { controller = "HaberKategori", action = "Anasayfa" }
            );
            }





        }
    }
}
