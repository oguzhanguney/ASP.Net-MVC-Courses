using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFramework.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        //ORM mantıgı ile Kategori sınıfının içinde de sanal olarak urun:birden fazla urun  olacagı için ICollection
        //veritabanımıza virtual olanlar gelmeyecek
        

        public virtual ICollection<Urun> Urun { get; set; }
    }
}