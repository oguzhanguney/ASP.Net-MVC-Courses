using MVCOgrenciBilgiSistemi_Controller.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCOgrenciBilgiSistemi_Controller.DAL
{
    public class OBSContext:DbContext
    {
        //constructor oluşturalım.
        public OBSContext() : base("OBSVeritabani") { }

        //dbset lerimizi ayarlayalım.
        public DbSet<Fakulte> Fakulteler { get; set; }

        //veritabanındaki s takısını kaldıralım:
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}