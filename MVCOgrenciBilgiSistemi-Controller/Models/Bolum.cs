using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOgrenciBilgiSistemi_Controller.Models
{
    public class Bolum
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        [DisplayName("Bölüm Adı")]
        [Required]
        public int FakulteId { get; set; }//çünkü bir bölümün bir fakültesi olur ama bir fakültenin birden çok bölümü olabilir.
        [DisplayName("Bölüm Adresi")]
        public string Adres { get; set; }

        //tekten çoga giderken bölüm->fakulte  codefirst virtual :
        public virtual Fakulte Fakulte { get; set; }

        //bolumu oluşturduktan sonra yapmamız gereken databasecontext imizde gidip datasetimizi oluşturmak.
    }
}