using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebHelpers.Models
{
    public class Veri
    {
        private static List<Urun> _urunler = new List<Urun>()
        {
                new Urun{ Id=1,Ad="Bilgisayar1",Fiyat=2000,Adet=20},
                new Urun{ Id=2,Ad="Masa1",Fiyat=500,Adet=620},
                new Urun{ Id=3,Ad="Tv1",Fiyat=3000,Adet=120},
                new Urun{ Id=4,Ad="Telefon1",Fiyat=1000,Adet=240},
                new Urun{ Id=5,Ad="Kitap1",Fiyat=20,Adet=206},
                new Urun{ Id=6,Ad="Bilgisayar2",Fiyat=2000,Adet=20},
                new Urun{ Id=7,Ad="Masa2",Fiyat=500,Adet=620},
                new Urun{ Id=8,Ad="Tv2",Fiyat=3000,Adet=120},
                new Urun{ Id=9,Ad="Telefon2",Fiyat=1000,Adet=240},
                new Urun{ Id=10,Ad="Kitap2",Fiyat=20,Adet=206},
                new Urun{ Id=11,Ad="Bilgisayar3",Fiyat=2000,Adet=20},
                new Urun{ Id=12,Ad="Masa3",Fiyat=500,Adet=620},
                new Urun{ Id=13,Ad="Tv3",Fiyat=3000,Adet=120},
                new Urun{ Id=14,Ad="Telefon3",Fiyat=1000,Adet=240},
                new Urun{ Id=15,Ad="Kitap3",Fiyat=20,Adet=206}
        };

        //şimdi bu nesneleri dışarı açalım

        public static List<Urun> Urunler
        {
            get
            {
                return _urunler;
            }
        }

        //ürün sorgula metodunu yazalım.

        public static List<Urun> UrunSorgula(string urunAd)
        {
            if (string.IsNullOrEmpty(urunAd))
                return _urunler;

            var urunler=(from u in _urunler where u.Ad.Contains(urunAd) select u).ToList();
            return urunler;
        }
    }
}