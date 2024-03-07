using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCEntityFramework.DAL
{
    public class SatisContext:DbContext
    {

        public SatisContext() : base("SatisVeriTabani") { } //constructor oluşturduk.
        
        //-Constructor oluşturduktan sonra entityframework ile veritabanındaki verilere DbSet üzerinden erişilmekte ve işlemler yapılmaktadır.
        //DbSet tanımalayalım.
        public DbSet<Kategori> Kategoriler { get; set; }//aynı şekil urun modelimiz içinde db set tanımlayacagız.
        public DbSet<Urun> Urunler { get; set; }

        //şimdi biz veritabanı oluşurken tablolar oluşurken bu tablolarımıza sonuna s takısı koymasını engellemek için
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}