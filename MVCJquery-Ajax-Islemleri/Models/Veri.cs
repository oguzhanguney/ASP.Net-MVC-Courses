using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJquery_Ajax_Islemleri.Models
{
    public class Veri
    {
        private static List<Urun> _urunler;

        public static List<Urun> Urunler
        {
            get
            {
                if(_urunler == null)
                {
                    _urunler = new List<Urun>
                    {
                        new Urun
                        {
                            Id = 1,Ad="Bilgisayar",Fiyat=4000
                        },
                        new Urun
                        {
                            Id = 2,Ad="Telefon",Fiyat=3000
                        },
                        new Urun
                        {
                            Id = 3,Ad="Tv",Fiyat=5000
                        }
                    };
                }
                return _urunler;
            }
        }
    }
}