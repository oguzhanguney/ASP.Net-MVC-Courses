using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOgrenciBilgiSistemi_Controller.Models
{
    public class Fakulte
    {
        public int Id { get; set; }
        [DisplayName("Fakülte Adı")]
        [Required]
        public string FakulteAd { get; set; }
        //biz bir fakülteyi silmek istedigimizde veritabanından içindeki tüm bölümleri tek tek silmemiz gerekir.bunun için biz fakültenin aktif mi pasif mi 
        //özelligini ayarlayalım.
        [DisplayName("Silindi")]
        [Required]
        public bool Sil { get; set; }
    }
}