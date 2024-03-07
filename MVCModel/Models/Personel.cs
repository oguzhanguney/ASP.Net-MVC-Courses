using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModel.Models
{
    //Model oluşturduk.Personelimizin şablonunu tutacak bir class oluşturduk.
    //Modeli oluşturduktan sonra bu modele veri girişlerini yapalım.projemizde yeni bir klasör açalım.(Veri)
    //veri klasörüne add-class (personelVeriler)
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Islem { get; set; }

    }
}