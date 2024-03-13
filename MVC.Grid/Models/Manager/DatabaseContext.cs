using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Grid.Models.Manager
{
    public class DatabaseContext:DbContext  //manage nuget:entity framework dahil et.
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Adres> Adresler { get; set; }

        //olusturucu metodunu databsecontext içinde kullanmamız lazım .constructor olarak
        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new Olusturucu());
        }
    }
        
    //bunları ekledikten sonra ben database im oluşmadıysa oluşturma ve de oluşurken birtakım veriler eklemek için bir metot daha kullanalım.eğer bu metot database oluşmussa çalışmayacak bir metot olacak.
    public class Olusturucu : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //fakedata kullanarak bir takım veriler eklemek istiyorum. manage nuget :fakedata ekle
            //fake data ekledikten sonra  10 tane ülke ve 100 tane personel oluşturalım. ve veritabanımızı çalışır bir duruma getirelim.
            List<Ulke> ulkeList= new List<Ulke>();
            for (int i = 0; i < 10; i++)
            {
                Ulke ulke = new Ulke();
                ulke.Ad = FakeData.PlaceData.GetCountry();
                ulkeList.Add(ulke);
                context.Ulkeler.Add(ulke);
            }
            //contexti veritabanı ile baglamamız lazım
            context.SaveChanges();
            for (int i = 0;i < 100;i++)
            {
                Personel per= new Personel();
                per.Ad=FakeData.NameData.GetFirstName();
                per.Soyad=FakeData.NameData.GetSurname();
                per.Yas=FakeData.NumberData.GetNumber(10,90);

                Random r= new Random();
                int deger=r.Next(0,10);
                per.Ulke = ulkeList[deger];

                context.Personeller.Add(per);
            }
            context.SaveChanges();
        }
    }
}