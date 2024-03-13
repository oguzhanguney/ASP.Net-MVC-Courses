using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Grid.Models
{
    [Table("Ulkeler")] //tablo adı belirleme
    public class Ulke
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]//(id özelligini primary key yapmak için [key], id'nin 1 den başlayıp birer birer artmasını saglamak içinde databasegeneratedoption.identity
        public int Id { get; set; }
        public string Ad { get; set; }

        //ülke birden fazla personele sahip olabilecegi için:
        public List<Personel> Personeller { get; set; }
    }
}