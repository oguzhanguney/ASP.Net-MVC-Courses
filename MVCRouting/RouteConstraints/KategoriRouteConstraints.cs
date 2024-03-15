using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCRouting.RouteConstraints
{
    public class KategoriRouteConstraints : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            //öncelikle values üzerinden kategori bilgisini alacagız.ve veritabanı kontrol yapmamız içinde liste oluşturacagız.
            string kategoriAd = values["kategori"].ToString();

            List<string> kategoriler = new List<string>()
            {
                "Güncel Haberler","Magazin","Spor","Savaş" // bu kategorilerin bizim veritabanımızda oldugunu düşünelim.
            };

            if (kategoriler.Contains(kategoriAd))
                return true;
            else 
                return false;
        }
    }
}