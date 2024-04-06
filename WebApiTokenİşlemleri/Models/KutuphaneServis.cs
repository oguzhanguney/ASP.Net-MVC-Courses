using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiTokenİşlemleri.Models
{
    public class KutuphaneServis:DbContext
    {
        //constructor:
        public KutuphaneServis() : base("name=KutuphaneEntity")
        {

        }
        //Kitapları tutan DbSeti ayarlayalım.
        public DbSet<Kitap> Kitaplar {  get; set; } 
        //webconfige giderek connectionstring ayarlaması yapalım.
    }
}