using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiToken.Models;

namespace WebApiToken
{
    public class Login
    {
        public static bool Giris(string ad,string parola)
        {
            //veritabanı baglantısı -kontrol
            using(PersonelVeritabaniEntities entity=new PersonelVeritabaniEntities())
            {
                return entity.Yetkililer.Any(x=>x.kullaniciAd.Equals(ad,StringComparison.OrdinalIgnoreCase) && x.parola==parola);
            }
            //şimdi bizim veritabanındaki personellerin bu yetkiye baglı olarak oluşturdugumuz attr içerisinde giriş metodunu kullandırtırarak web api controller oluştralım.(personeller)
        }
    }
}