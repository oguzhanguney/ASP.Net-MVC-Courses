using MVCRouting.RouteConstraints;
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
                url: "anasayfa",//tek bir sayfadan oluşacagı için direk anasayfa diyelim.sabit bir link vermiş olduk.
                defaults: new { controller = "Site", action = "Anasayfa" }
            );


            //Kategori Route:

            int kirilimSayisi = 3; //veri tabanından sorgu yaptık kırılım sayımızı max olarak 3 bulduk ve getirdik 
            string kategoriUrl = "kategori";
            string haberUrl = "haber";
            //şimdi bir for döngüsü ile kategori url sini hazırlayalım .kırılım sayısına göre bu url değişkenlik gösterecek.

            for (int i = 0; i < kirilimSayisi; i++)
            {
                kategoriUrl += "/{kategori" + i + "}";

                routes.MapRoute(
                    name: "Kategori"+i,
                    url: kategoriUrl,
                    defaults: new { controller = "HaberKategori", action = "Anasayfa" }
                );

                haberUrl += "/{haber" + i + "}";

                routes.MapRoute(
                    name: "Haber" +i,
                    url: haberUrl+"/{haber}",
                    defaults: new { controller = "Haber", action = "Detay" }
                );
            }

            //Regular Expression Route kısıtlaması:
            routes.MapRoute(
                name: "ArsivTarih",
                url: "arsiv/{tarih}",
                defaults: new { controller = "Site", action = "ArsivTarih" },
                constraints: new { tarih =@"\d{4}-\d{2}-\d{2}"} //yıl-ay-gün şeklini vermiş olduk (yyyy-xx-xx) regular expression:
            );


            //HttpMetotConstraint Route kısıtlaması:
            routes.MapRoute(
                name: "HaberGöster",
                url: "haber/Goster",
                defaults: new { controller = "Haber", action = "Goster" },
                constraints: new { metod=new HttpMethodConstraint("GET") } //sadece get işlemi yapmasını sagladık.
            );
            routes.MapRoute(
                name: "HaberKaydet",
                url: "haber/Kaydet",
                defaults: new { controller = "Haber", action = "Kaydet" },
                constraints: new { metod = new HttpMethodConstraint("POST","PUT") } //birden fazla işlem yaptırabiliriz.
            );

            //Kullanıcı Tanımlı Route kısıtlaması:
            routes.MapRoute(
                name: "Kategori",
                url: "kategoriler/{kategori}",
                defaults: new { controller = "HaberKategori", action = "Anasayfaa" },
                constraints: new { kategori=new KategoriRouteConstraints() } 
            );

        }
    }
}
