using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Grid.Models
{
    [Table("Personeller")] //tablo adı belirleme
    public class Personel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]//(id özelligini primary key yapmak için [key], id'nin 1 den başlayıp birer birer artmasını saglamak içinde databasegeneratedoption.identity
        public int Id { get; set; }
        [StringLength(50), Required]//max 50 karakter olmasını ve boş geçilmesini engellemiş olduk.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        // bir başka tabloda bu personelimizin ülkelerinide yazmak istiyorum yeni bir class oluşturalım.

        //personeller ve ulkeler tablosunu baglamak için: personelim bir ülkeye baglı oldugu için ve bir personelin bir ülkesi oldugu için

        public Ulke Ulke { get; set; }
    }
}