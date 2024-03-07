using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityFramework.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        //normalde bir ürünün bir tane kategorisi olmaz ama bu örnek için bir ürünün bir kategorisi varmış gibi düşünecegiz.
        //Bir kategorininde birden fazla ürünü vardır diye düşünecegiz.
        //burada aslında biz KategoriId ile kategorimizin ıd sini tutuyoruz fakat entityframework ORM mantıgında kategori nesnemizide tutmalıyız burada.
        public virtual Kategori Kategori { get; set; }//bu prop sanal bir prop (urun için)
    }
}