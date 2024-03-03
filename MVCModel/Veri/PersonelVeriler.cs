using MVCModel.Models; //personel class ını tanıması için ekledik.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModel.Veri
{
    public class PersonelVeriler
    {
        //Burada bir liste tutmak istiyorum.
        //static:projemiz çalıştıgı sürece bu verileri kaybetmiyoruz.(ekle-çıkar işlemleri yapabilme)
        public static List<Personel> listPersoneller = new List<Personel>()
        {
            new Personel
            {
                Id = 1,
                Ad="Oğuzhan",
                Soyad="Güney",
                TCKN=12345678912,
                DogumTarihi=new DateTime(2000,08,09)
            },
            new Personel
            {
                Id = 2,
                Ad="Alican",
                Soyad="Sarıboga",
                TCKN=33255587712,
                DogumTarihi=new DateTime(2001,08,09)
            },
            new Personel
            {
                Id = 3,
                Ad="Fatih",
                Soyad="Terim",
                TCKN=11255587712,
                DogumTarihi=new DateTime(1995,08,09)
            }
        };
        //Listemizi oluşturdugumuza göre bu verileri listeleme işlemi yapalım.
        //Bunun için sayfaya bir controller(home) ekleyelim ve view i oluşturalım.
    }
}