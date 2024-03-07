using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAttribute.Models
{
    public class Uye
    {
        public int Id { get; set; }

        [DisplayName("Adınız")]//attributes2
        public string Ad { get; set; }

        [DisplayName("Soyadınız")]
        public string Soyad { get; set; }

        //Tckn nin mutlaka girilmesini istiyoruz.
        //şimdi zorunluluk attribute ekleyelim. 
        [Required]//attributes1
        [DisplayName("Tc Kimlik Numarası")]
        [MinLength(11,ErrorMessage ="Tc Kimlik No 11 hane olmak zorunda!")]//En az 11 karakter girilmeli. //artık deger tipi string olmalı double olamaz
        [MaxLength(11,ErrorMessage = "Tc Kimlik No 11 hane olmak zorunda!")]//En fazla 11 karakter girilmeli.//attributes6
        public string TCKimlikNo { get; set; }
        
        //bir detay sayfası yaparak tarihin nasıl göründügüne bakalım.
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}")]//tarihin görüntüleme formatını ayarladık attributes3
        [DisplayName("Üyelik Tarihi")]
        public DateTime UyelikTarihi { get; set; }

        [DataType(DataType.Password)]//attributes4
        public string Parola { get; set; }
        //Compare att bir başka prop ile karşılaştırma yapar-attributes7
        [DataType(DataType.Password)]
        [Compare("Parola")]
        public string ParolaTekrar { get; set; }

        [EmailAddress()]//attributes5
        public string EPosta { get; set; }




    }
}